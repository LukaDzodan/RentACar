using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVPDrugiProjekat
{
    public partial class AddReservationForm : Form
    {
        public AddReservationForm()
        {
            InitializeComponent();
        }

        private void AddReservationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddReservationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentACarDBDataSet.Klijent' table. You can move, or remove it, as needed.
            this.klijentTableAdapter.Fill(this.rentACarDBDataSet.Klijent);
            dgwSvaVozila.DataSource = Vozilo.getVozila();
            comboBox1.DataSource = Klijent.getKlijentiLista();
        }

        private void btnDodajRezervaciju_Click(object sender, EventArgs e)
        {
            List<Rezervacija> rezervacije = Rezervacija.getRezervacijeLista();

            DataGridViewRow selectedRow = dgwSvaVozila.SelectedRows[0];
            int idVozila = Convert.ToInt32(selectedRow.Cells["id_vozila"].Value);
            int cenaVozila = Convert.ToInt32(selectedRow.Cells["cena_po_satu"].Value);
            Klijent k = (Klijent)comboBox1.SelectedItem;
            int br = 0;

            if (dtpOd.Value.Day >= DateTime.Now.Day && dtpDo.Value.Day >= DateTime.Now.Day && dgwSvaVozila.SelectedRows.Count == 1) {

                foreach (Rezervacija r in rezervacije)
                {
                    if (((dtpOd.Value >= r.DatumVreme_pocetka && dtpOd.Value <= r.DatumVreme_kraja) || (dtpDo.Value >= r.DatumVreme_pocetka && dtpDo.Value <= r.DatumVreme_kraja)) && r.Id_vozila == idVozila)
                    {
                        br++;
                    }
                    else if (dtpOd.Value <= r.DatumVreme_pocetka && dtpDo.Value >= r.DatumVreme_kraja)
                    {
                        br++;
                    }
                }
                //MessageBox.Show("broj je " + br);
                if (br != 0)
                {
                    MessageBox.Show("Izabrano vozilo vec ima rezervaciju u tom periodu!");
                }
                else
                {
                    int cena = (int)((dtpDo.Value - dtpOd.Value).TotalHours * cenaVozila);
                    Rezervacija r = new Rezervacija(idVozila, k.Id_klijenta, dtpOd.Value, dtpDo.Value, cena);
                    r.InsertReservation();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Jedan od datuma je prosao!");
            }

            
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
