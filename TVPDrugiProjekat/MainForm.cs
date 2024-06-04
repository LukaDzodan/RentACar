using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVPDrugiProjekat
{
    public partial class MainForm : Form
    {

        RentACarDBDataSet dsVozilo = new RentACarDBDataSet();
        RentACarDBDataSet dsRezervacija = new RentACarDBDataSet();
        RentACarDBDataSetTableAdapters.RezervacijaTableAdapter daRezervacija = new RentACarDBDataSetTableAdapters.RezervacijaTableAdapter();
        RentACarDBDataSetTableAdapters.VoziloTableAdapter daVozilo = new RentACarDBDataSetTableAdapters.VoziloTableAdapter();


        private static string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\dzoni\OneDrive\Desktop\RentACarDB.accdb";
        Baza baza = new Baza(connString);
        public MainForm()
        {
            InitializeComponent();
            cbKategorija.SelectedIndexChanged += new EventHandler(this.cbNazivKetegorije_SelectedIndexChanged);
            this.Paint += new PaintEventHandler(this.MainForm_Paint);
        }
        Thread t;
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            t.Abort();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentACarDBDataSet.Vozilo' table. You can move, or remove it, as needed.
            this.voziloTableAdapter.Fill(this.rentACarDBDataSet.Vozilo);
            // TODO: This line of code loads data into the 'rentACarDBDataSet.Kategorija' table. You can move, or remove it, as needed.
            this.kategorijaTableAdapter.Fill(this.rentACarDBDataSet.Kategorija);
            //Kategorija k = new Kategorija("Nista", "Ti ga mami ja");
            //Vozilo v = new Vozilo("Limuzina", "Audi A8", "Audi", "A8", 1998, 200);
            //v.insertVozilo();
            //Klijent k = new Klijent("Luka", "Dzodan", "Vb 66", "062/292-410", 'B');
            //k.insertClient();
            //Rezervacija r = new Rezervacija(1, 1, dateTimePicker1.Value, dateTimePicker1.Value, 500);
            //r.InsertRezervacija(r);
            //r.InsertReservation();
            //dgwSvaVozila.DataSource = Vozilo.getsAllVozila();
            //cbKategorija.DataSource = Kategorija.getKategorije();
            dgwSvaVozila.DataSource = Vozilo.getVozila();
            dgwSveRezervacije.DataSource = Rezervacija.getRezervacije();
            brojTrazenih = Kategorija.GetBrojRezervacijaZaKategoriju(comboBox1.Text.ToString());
            brojUkupnih = Kategorija.GetUkupanBrojRezervacija();

            lblNajposeceniji.Text = Vozilo.getNajcesceVozilo().ToString();
            t = new Thread(animacija);
            t.IsBackground = true;
            t.Start();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            daVozilo.Fill(dsVozilo.Vozilo);

            var redovi = from vozilo in dsVozilo.Vozilo
                         where vozilo.id_kategorije == (cbKategorija.SelectedIndex+1)
                         select vozilo;

            DataTable filtrirano = dsVozilo.Vozilo.Copy();
            filtrirano.Clear();

            foreach (var red in redovi)
            {
                DataRow noviRed = filtrirano.NewRow();
                for (int i = 0; i < dsVozilo.Vozilo.Columns.Count; i++)
                {
                    noviRed[i] = red[i];
                }
                filtrirano.Rows.Add(noviRed);
            }

            dgwSvaVozila.DataSource = filtrirano;

            if(!redovi.Any())
            {
                MessageBox.Show("Ne postoji ni jedno vozilo u toj kategoriji trenutno!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddReservationForm addReservationForm = new AddReservationForm();
            this.Hide();
            addReservationForm.Show();
        }

        private void btnFiltrirajPoSatu_Click(object sender, EventArgs e)
        {
            daVozilo.Fill(dsVozilo.Vozilo);

            var redovi = from vozilo in dsVozilo.Vozilo
                         where vozilo.cena_po_satu >= int.Parse(txtCenaOd.Text) && vozilo.cena_po_satu <= int.Parse(txtCenaDo.Text)
                         select vozilo;

            DataTable filtrirano = dsVozilo.Vozilo.Copy();
            filtrirano.Clear();

            foreach (var red in redovi)
            {
                DataRow noviRed = filtrirano.NewRow();
                for (int i = 0; i < dsVozilo.Vozilo.Columns.Count; i++)
                {
                    noviRed[i] = red[i];
                }
                filtrirano.Rows.Add(noviRed);
            }

            dgwSvaVozila.DataSource = filtrirano;

            if (!redovi.Any())
            {
                MessageBox.Show("Ne postoji ni jedno vozilo sa takvom cenom trenutno!");
            }
        }

        private void btnFiltrirajPoDatumu_Click(object sender, EventArgs e)
        {
            int rez = 0;
            List<Vozilo> vozila = new List<Vozilo>();
            try
            {
                baza.openConnect();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                //cmd.CommandText = "SELECT * FROM Vozilo v JOIN Rezervacija r ON v.id_vozila = r.id_vozila AND r.datumVreme_pocetka < @datumDo AND r.datumVreme_kraja > @datumOd WHERE r.id_rezervacija IS NULL";
                //cmd.CommandText = "SELECT * FROM Vozilo v JOIN Rezervacija r ON v.id_vozila = r.id_vozila WHERE r.datumVreme_pocetka <= @datumDo AND r.datumVreme_kraja >= @datumOd AND r.id_rezervacija IS NULL";
                cmd.CommandText = "SELECT * FROM Vozilo WHERE id_vozila NOT IN(SELECT id_vozila FROM Rezervacija WHERE (datumVreme_pocetka BETWEEN @datumOd AND @datumDo) OR (datumVreme_kraja BETWEEN @datumOd AND @datumDo))";
                cmd.Parameters.AddWithValue("datumOd", dtpOd.Value.Date);
                cmd.Parameters.AddWithValue("datumDo", dtpDo.Value.Date);

                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Vozilo v = new Vozilo();
                    v.Id_vozila = int.Parse(reader["id_vozila"].ToString());
                    v.Id_kategorije = int.Parse(reader["id_kategorije"].ToString());
                    v.Naziv = reader["naziv"].ToString();
                    v.Marka = reader["marka"].ToString();
                    v.Model = reader["model"].ToString();
                    v.Godina_proizvodnje = int.Parse(reader["godina_proizvodnje"].ToString());
                    v.Cena_po_satu = int.Parse(reader["cena_po_satu"].ToString());

                    vozila.Add(v);
                    rez++;
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baza.closeConnect();
            }

            if(rez == 0)
            {
                MessageBox.Show("Ne postoje vozila u tom terminu");
            }
            dgwSvaVozila.DataSource = vozila;

        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            AddVoziloForm addVoziloForm = new AddVoziloForm();
            addVoziloForm.Show();
            this.Hide();
        }

        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            AddKategorijaForm addKategorijaForm = new AddKategorijaForm();
            addKategorijaForm.Show();
            this.Hide();
        }

        private void btnDodajKlijenta_Click(object sender, EventArgs e)
        {
            AddKlijentForm addKlijentForm = new AddKlijentForm();
            addKlijentForm.Show();
            this.Hide();
        }

        private void btnFiltritajRezervacije_Click(object sender, EventArgs e)
        {
            dgwSveRezervacije.DataSource = Rezervacija.getRezervacijeFilter(dtpOdRezervacije.Value.Date, dtpDoRezervacije.Value.Date);
        }

        private void cbNazivKetegorije_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            //Invalidate();
        }
        int brojTrazenih = 0;
        int brojUkupnih = 0;
        private void crtaj(object sender,PaintEventArgs e)
        {
            float x;
            if (brojUkupnih == 0) return;

            Random rnd = new Random();
            Rectangle r = new Rectangle(1280, 100, 200, 200);
            float startUgao = -90.0F;

            if(brojTrazenih == 0)
            {
                x = 0.0f;
            }
            else
            {
                 x = (brojTrazenih * 360) / brojUkupnih;
            }

            //MessageBox.Show(x.ToString());
            Color boja = Color.Aqua;
            SolidBrush cetka = new SolidBrush(boja);
            e.Graphics.FillEllipse(Brushes.Red, r);
            e.Graphics.FillPie(cetka, r, startUgao, x);
            
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            //crtaj(e);
        }
        bool dodato = true;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            brojTrazenih = Kategorija.GetBrojRezervacijaZaKategoriju(comboBox1.Text.ToString());
            brojUkupnih = Kategorija.GetUkupanBrojRezervacija();


            //int brojTrazenih = Kategorija.GetBrojRezervacijaZaKategoriju(comboBox1.Text);
            //int brojUkupnih = Kategorija.GetUkupanBrojRezervacija();
            //MessageBox.Show("Broj trazenih:" + brojTrazenih + "brojUkupnih" + brojUkupnih);
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            if (dodato)
            {
                this.Paint += crtaj;
                dodato = false;
                
            }
            Invalidate();
            lblPrikaz.Text = "Brojcano: " + brojTrazenih + " Procentualno: " + (brojTrazenih * 100) / brojUkupnih;
        }

        private void dgwSveRezervacije_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow selectedRow = dgwSveRezervacije.SelectedRows[0];
            int idRez = Convert.ToInt32(selectedRow.Cells["id_rezervacija"].Value);
            int idVozila = Convert.ToInt32(selectedRow.Cells["id_vozila"].Value);
            int idKlijenta = Convert.ToInt32(selectedRow.Cells["id_klijenta"].Value);
            DateTime datumVreme_pocetka = Convert.ToDateTime(selectedRow.Cells["datumVreme_pocetka"].Value);
            DateTime datumVreme_kraja = Convert.ToDateTime(selectedRow.Cells["datumVreme_kraja"].Value);
            int cena = Convert.ToInt32(selectedRow.Cells["cena"].Value);

            Rezervacija r = new Rezervacija(idRez,idVozila,idKlijenta,datumVreme_pocetka,datumVreme_kraja,cena);

            ChangeRezervacijaForm changeRezervacijaForm = new ChangeRezervacijaForm(r);
            this.Hide();
            changeRezervacijaForm.Show();

        }

        public void animacija()
        {
            int step = 1;
            Point p = new Point(0,dgwSveRezervacije.Location.Y);
            Size velicina = new Size(100, 100);
            while (true)
            {
                if (p.Y == this.ClientSize.Height - 100)
                    step = -1;
                if (p.Y == dgwSveRezervacije.Location.Y)
                    step = 1;

                // ili
                //if (p.Y == this.ClientSize.Height - velicina.Height || p.Y == 0)
                //    korak = -korak;

                p.Y += step;
                lblNajposeceniji.Top = p.Y;
                //Invalidate();
                Thread.Sleep(10);
            }
        }

        private void btnSveRezervacije_Click(object sender, EventArgs e)
        {
            dgwSveRezervacije.DataSource = null;
            dgwSveRezervacije.DataSource = Rezervacija.getRezervacije();
        }
    }
}
