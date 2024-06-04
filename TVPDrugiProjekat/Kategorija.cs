using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVPDrugiProjekat
{
    class Kategorija
    {
        static RentACarDBDataSet ds = new RentACarDBDataSet();
        static RentACarDBDataSetTableAdapters.KategorijaTableAdapter da = new RentACarDBDataSetTableAdapters.KategorijaTableAdapter();

        private static string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\dzoni\OneDrive\Desktop\RentACarDB.accdb";
        static Baza baza = new Baza(connString);


        private int id_kategorije;
        private  string naziv;
        private  string opis;

        public Kategorija(string naziv, string opis)
        {
            this.id_kategorije = addId();
            this.naziv = naziv;
            this.opis = opis;
        }

        public Kategorija()
        {
        }

        public int Id_kategorije { get => id_kategorije; set => id_kategorije = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Opis { get => opis; set => opis = value; }

        public static void insertKategorija(string Naziv,string opis)
        {
            int rez = da.Insert(Naziv,opis);
            if (rez > 0)
            {
                MessageBox.Show("Uspesno ste dodali kategoriju!");
                da.Fill(ds.Kategorija);
            }
        }


        public static List<Kategorija> getKategorijaLista()
        {
            List<Kategorija> kategorije = new List<Kategorija>();
            try
            {
                baza.openConnect();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT * FROM Kategorija";
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Kategorija k = new Kategorija();
                    k.id_kategorije = int.Parse(reader["id_kategorije"].ToString());
                    k.naziv = reader["naziv"].ToString();
                    k.opis = reader["opis"].ToString();

                    kategorije.Add(k);
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

            return kategorije;
        }

        private int addId()
        {
            int id = 0;
            try
            {
                baza.openConnect();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT MAX(id_kategorije) FROM Kategorija";
                id = Int32.Parse(cmd.ExecuteScalar().ToString());
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                baza.closeConnect();
            }

            return (id+1);
        }

        public static int GetBrojRezervacijaZaKategoriju(string nazivKategorije)
        {
            int brojRezervacija = 0;
            object result;
            string connectionString = connString;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                //MessageBox.Show("Naziv" + nazivKategorije);
                string query = "SELECT COUNT(*) AS broj_rezervacija " +
                       "FROM Rezervacija " +
                       "WHERE id_vozila IN (SELECT id_vozila " +
                                           "FROM Vozilo " +
                                           "WHERE id_kategorije IN (SELECT id_kategorije " +
                                                                   "FROM Kategorija " +
                                                                   "WHERE naziv = @kategorija))";

                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@kategorija", Convert.ToChar(nazivKategorije));
                    connection.Open();
                    result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
            {
                brojRezervacija = Convert.ToInt32(result);
            }
                }
            }
            return brojRezervacija;
        }

        public static int GetUkupanBrojRezervacija()
        {
            int brojRezervacija = 0;
            string connectionString = connString;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT COUNT(*) AS broj_rezervacija FROM Rezervacija";

                using (OleDbCommand cmd = new OleDbCommand(query, connection))
                {
                    connection.Open();
                    brojRezervacija = int.Parse(cmd.ExecuteScalar().ToString());
                }
            }
            return brojRezervacija;
        }


    }
}
