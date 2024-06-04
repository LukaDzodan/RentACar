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
    public partial class AddKlijentForm : Form
    {
        public AddKlijentForm()
        {
            InitializeComponent();
        }

        private void AddKlijentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentACarDBDataSet.Kategorija' table. You can move, or remove it, as needed.
            this.kategorijaTableAdapter.Fill(this.rentACarDBDataSet.Kategorija);

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            List < Klijent > klijenti = Klijent.getKlijentiLista();
            int br = 0;
            if (!(txtIme.Text == "" || txtPrezime.Text == "" || txtTelefon.Text == "" || txtAdresa.Text == ""))
            {
                if (proveriString(txtIme.Text) && proveriString(txtPrezime.Text))
                {
                    Klijent klijent = new Klijent(txtIme.Text, txtPrezime.Text, txtAdresa.Text, txtTelefon.Text, Convert.ToChar(cbKategorija.SelectedValue));

                    foreach(Klijent k in klijenti)
                    {
                        if (k.Ime == txtIme.Text && k.Prezime == txtPrezime.Text && k.Adresa == txtAdresa.Text && k.Telefon == txtTelefon.Text && k.Vozacka_kategorija == Convert.ToChar(cbKategorija.SelectedValue)) {
                            br++;
                        }
                    }
                    if(br == 0)
                    {
                        Klijent.insertKlijent(txtIme.Text, txtPrezime.Text, txtAdresa.Text, txtTelefon.Text, Convert.ToChar(cbKategorija.SelectedValue));
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Takav klijent vec postoji!");
                    }
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

        private void btnNazad_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
