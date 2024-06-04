using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVPDrugiProjekat
{
    public partial class ChangeRezervacijaForm : Form
    {
        MainForm mainForm = new MainForm();
        Rezervacija rezervacija;
        private static string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\dzoni\OneDrive\Desktop\RentACarDB.accdb";
        static Baza baza = new Baza(connString);
        public ChangeRezervacijaForm(Rezervacija rezervacija)
        {
            InitializeComponent();
            this.rezervacija = rezervacija;
        }

        private void ChangeRezervacijaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentACarDBDataSet.Klijent' table. You can move, or remove it, as needed.
            this.klijentTableAdapter.Fill(this.rentACarDBDataSet.Klijent);
            cbKlijenti.DataSource = Klijent.getKlijentiLista();
            dtpPocetak.Value = rezervacija.DatumVreme_pocetka;
            dtpKraj.Value = rezervacija.DatumVreme_kraja;
            dataGridView1.DataSource = Vozilo.getVozilaLista();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["id_vozila"].Value != null && (int)row.Cells["id_vozila"].Value == rezervacija.Id_vozila)
                {
                    row.Selected = true;

                    dataGridView1.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }

        private void ChangeRezervacijaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            List<Rezervacija> rezervacije = Rezervacija.getRezervacijeLista();
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            int idVozila = Convert.ToInt32(selectedRow.Cells["id_vozila"].Value);
            int cenaVozila = Convert.ToInt32(selectedRow.Cells["cena_po_satu"].Value);
            Klijent k = (Klijent)cbKlijenti.SelectedItem;
            int cena = (int)((dtpKraj.Value - dtpPocetak.Value).TotalHours * cenaVozila);
            Rezervacija novaRezervacija = new Rezervacija(idVozila, k.Id_klijenta, dtpPocetak.Value, dtpKraj.Value, cena);
            int br = 0;
            List<Rezervacija> rezervacijeBezRezKojaSeMenja = Rezervacija.getRezervacijeListaBezTrazene(rezervacija.Id_rezervacija);
            foreach (Rezervacija r in rezervacijeBezRezKojaSeMenja)
            {
                if (((novaRezervacija.DatumVreme_pocetka >= r.DatumVreme_pocetka && novaRezervacija.DatumVreme_pocetka <= r.DatumVreme_kraja) || (novaRezervacija.DatumVreme_kraja >= r.DatumVreme_pocetka && novaRezervacija.DatumVreme_kraja <= r.DatumVreme_kraja)) && r.Id_vozila == idVozila)
                {
                    br++;
                }
                else if(novaRezervacija.DatumVreme_pocetka <= r.DatumVreme_pocetka && novaRezervacija.DatumVreme_kraja >= r.DatumVreme_kraja)
                {
                    br++;
                }
            }

            if (br == 0)
            {
                int rez = 0;
                try
                {
                    baza.openConnect();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = baza.Conn;
                    //MessageBox.Show("Id rezervacije" + (rezervacija.Id_rezervacija - 1));
                    cmd.CommandText = "UPDATE Rezervacija SET id_vozila=@id_vozila, id_klijenta=@id_klijenta, datumVreme_pocetka=@datumVreme_pocetka" +
                        ", datumVreme_kraja=@datumVreme_kraja , cena =@cena WHERE id_rezervacija = " + rezervacija.Id_rezervacija;

                    cmd.Parameters.AddWithValue("id_vozila", idVozila);
                    cmd.Parameters.AddWithValue("id_klijenta", k.Id_klijenta);
                    cmd.Parameters.AddWithValue("datumVreme_pocetka", dtpPocetak.Value.Date);
                    cmd.Parameters.AddWithValue("datumVreme_kraja", dtpKraj.Value.Date);
                    cmd.Parameters.AddWithValue("cena", cena);

                    rez = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    baza.closeConnect();
                }
                if (rez != 0)
                {
                    MessageBox.Show("Uspesno ste izmenili rezervaciju!");
                    mainForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Taj auto je vec rezervisan u tom terminu!");
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int rez = 0;
            try
            {
                baza.openConnect();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                //MessageBox.Show("Id rezervacije" + (rezervacija.Id_rezervacija - 1));
                cmd.CommandText = "DELETE * FROM Rezervacija WHERE id_rezervacija="+rezervacija.Id_rezervacija;

                rez = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baza.closeConnect();
            }
            if (rez != 0)
            {
                MessageBox.Show("Uspesno ste obrisali rezervaciju!");
                mainForm.Show();
                this.Hide();
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
        }
    }
}
