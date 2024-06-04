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
    public partial class AddKategorijaForm : Form
    {
        public AddKategorijaForm()
        {
            InitializeComponent();
        }

        MainForm MainForm = new MainForm();

        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            List<Kategorija> kategorije = Kategorija.getKategorijaLista();
            int br = 0;
            if(txtKategorija.Text != "" && txtOpisKategorije.Text != "")
            {
                if (proveriString(txtKategorija.Text))
                {

                    foreach(Kategorija k in kategorije)
                    {
                        if(k.Naziv == txtKategorija.Text)
                        {
                            br++; 
                        }
                    }

                    if(br == 0)
                    {
                        Kategorija.insertKategorija(txtKategorija.Text, txtOpisKategorije.Text);
                        MainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Ta kategorija vec postoji!");
                    }


                }
                else
                {
                    MessageBox.Show("Neko od polja ima nevalidan format!");
                }
            }
            else
            {
                MessageBox.Show("Neko od polja nije popunjeno!");
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
                }
            }
            return istina;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            MainForm.Show();
            this.Hide();
        }

        private void AddKategorijaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
