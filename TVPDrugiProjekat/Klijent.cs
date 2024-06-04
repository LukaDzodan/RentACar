using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVPDrugiProjekat
{
    class Klijent
    {
        static RentACarDBDataSet ds = new RentACarDBDataSet();
        static RentACarDBDataSetTableAdapters.KlijentTableAdapter da = new RentACarDBDataSetTableAdapters.KlijentTableAdapter();

        private static string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\dzoni\OneDrive\Desktop\RentACarDB.accdb";
        static Baza baza = new Baza(connString);

        private int id_klijenta;
        private string ime;
        private string prezime;
        private string adresa;
        private string telefon;
        private char vozacka_kategorija;

        public Klijent(string ime, string prezime, string adresa, string telefon, char vozacka_kategorija)
        {
            this.id_klijenta = addId();
            this.ime = ime;
            this.prezime = prezime;
            this.adresa = adresa;
            this.telefon = telefon;
            this.vozacka_kategorija = vozacka_kategorija;
        }
        public Klijent()
        {

        }


        public int Id_klijenta { get => id_klijenta; set => id_klijenta = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public char Vozacka_kategorija { get => vozacka_kategorija; set => vozacka_kategorija = value; }

        //public void insertClient()
        //{
        //    int rez = 0;
        //    try
        //    {
        //        baza.openConnect();
        //        OleDbCommand cmd = new OleDbCommand();
        //        cmd.Connection = baza.Conn;
        //        cmd.CommandText = "INSERT INTO Klijent VALUES (@ime,@prezime,@adresa,@telefon,@vozacka_kategorija)";

        //        //cmd.Parameters.AddWithValue("id_klijenta", id_klijenta);
        //        cmd.Parameters.AddWithValue("ime", ime);
        //        cmd.Parameters.AddWithValue("prezime", prezime);
        //        cmd.Parameters.AddWithValue("adresa", adresa);
        //        cmd.Parameters.AddWithValue("telefon", telefon);
        //        cmd.Parameters.AddWithValue("vozacka_kategorija", vozacka_kategorija);

        //        rez = cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //    finally
        //    {
        //        baza.closeConnect();
        //    }
        //    if (rez != 0)
        //    {
        //        MessageBox.Show("Uspesno ste dodali klijenta!");
        //    }
        //}

        public static void insertKlijent(string ime, string prezime,string adresa, string telefon, char vozacka_kategorija)
        {
            int rez = da.Insert(ime, prezime,adresa,telefon,vozacka_kategorija.ToString());
            if (rez > 0)
            {
                MessageBox.Show("Uspesno ste dodali klijenta!");
                da.Fill(ds.Klijent);
            }
        }

        public static List<Klijent> getKlijentiLista()
        {
            List<Klijent> klijenti = new List<Klijent>();
            try
            {
                baza.openConnect();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT * FROM Klijent";
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Klijent v = new Klijent();
                    v.id_klijenta = int.Parse(reader["id_klijenta"].ToString());
                    v.ime = reader["ime"].ToString();
                    v.prezime = reader["prezime"].ToString();
                    v.adresa = reader["adresa"].ToString();
                    v.telefon = reader["telefon"].ToString();
                    v.vozacka_kategorija = Convert.ToChar(reader["vozacka_kategorija"]);

                    klijenti.Add(v);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                baza.closeConnect();
            }

            return klijenti;
        }

        private int addId()
        {
            int id = 0;
            try
            {
                baza.openConnect();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT MAX(id_klijenta) FROM Klijent";
                id = Int32.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                baza.closeConnect();
            }

            return (id + 1);
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
