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
    public partial class AddVoziloForm : Form
    {
        public AddVoziloForm()
        {
            InitializeComponent();
        }

        private void AddVoziloForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Vozilo> vozila = Vozilo.getVozilaLista();

            if(!(txtNaziv.Text == "" || txtMarka.Text == "" || txtModel.Text == "" || txtGodinaProizvodnje.Text == "" || txtCenaPoSatu.Text == ""))
            {
                if(proveriInt(txtGodinaProizvodnje.Text) && proveriInt(txtCenaPoSatu.Text) && proveriString(txtMarka.Text) && proveriString(txtModel.Text) && proveriString(txtNaziv.Text))
                {
                    //MessageBox.Show("bla bla"+cbKategorija.SelectedValue.ToString());
                    Vozilo v = new Vozilo(int.Parse(cbKategorija.SelectedValue.ToString()), txtNaziv.Text, txtMarka.Text, txtModel.Text, int.Parse(txtGodinaProizvodnje.Text), int.Parse(txtCenaPoSatu.Text));

                    v.insertVozilo();
                }
                else
                {
                    MessageBox.Show("Negde nije unesen dobar format!");
                }

            }
            else
            {
                MessageBox.Show("Neko od polja nije popunjeno");
            }
        }

        private void AddVoziloForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentACarDBDataSet.Kategorija' table. You can move, or remove it, as needed.
            this.kategorijaTableAdapter.Fill(this.rentACarDBDataSet.Kategorija);

        }

        private bool proveriInt(string tekst)
        {
            bool istina = true;
            foreach (char c in tekst)
            {
                if (!char.IsDigit(c))
                {
                    istina = false;
                    break;
                }
            }
            return istina;
        }

        private bool proveriString(string tekst)
        {
            bool istina = true;
            foreach (char c in tekst)
            {
                if (!char.IsLetter(c))
                {
                    istina = false;
                    break;
                    MessageBox.Show("Zajebao si seee"); 
                }
            }
            return istina;
        }
    }
}
