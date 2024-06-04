using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVPDrugiProjekat
{
    public class Rezervacija
    {
        static RentACarDBDataSet ds = new RentACarDBDataSet();
        static RentACarDBDataSetTableAdapters.RezervacijaTableAdapter da = new RentACarDBDataSetTableAdapters.RezervacijaTableAdapter();

        private static string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\dzoni\OneDrive\Desktop\RentACarDB.accdb";
        static Baza baza = new Baza(connString);

        private int id_rezervacija;
        private int id_vozila;
        private int id_klijenta;
        private DateTime datumVreme_pocetka;
        private DateTime datumVreme_kraja;
        private int cena;

        public Rezervacija(int id_vozila, int id_klijenta, DateTime datumVreme_pocetka, DateTime datumVreme_kraja, int cena)
        {
            this.id_rezervacija = addId();
            this.id_vozila = id_vozila;
            this.id_klijenta = id_klijenta;
            this.datumVreme_pocetka = datumVreme_pocetka;
            this.datumVreme_kraja = datumVreme_kraja;
            this.cena = cena;
        }

        public Rezervacija(int id_rezervacija,int id_vozila, int id_klijenta, DateTime datumVreme_pocetka, DateTime datumVreme_kraja, int cena)
        {
            this.id_rezervacija = id_rezervacija;
            this.id_vozila = id_vozila;
            this.id_klijenta = id_klijenta;
            this.datumVreme_pocetka = datumVreme_pocetka;
            this.datumVreme_kraja = datumVreme_kraja;
            this.cena = cena;
        }
        public Rezervacija()
        {
        }

        public int Id_rezervacija { get => id_rezervacija; set => id_rezervacija = value; }
        public int Id_vozila { get => id_vozila; set => id_vozila = value; }
        public int Id_klijenta { get => id_klijenta; set => id_klijenta = value; }
        public DateTime DatumVreme_pocetka { get => datumVreme_pocetka; set => datumVreme_pocetka = value; }
        public DateTime DatumVreme_kraja { get => datumVreme_kraja; set => datumVreme_kraja = value; }
        public int Cena { get => cena; set => cena = value; }

        public static DataTable getRezervacije()
        {
            da.Fill(ds.Rezervacija);
            DataTable lista = ds.Rezervacija.Copy();
            return lista;
        }

        public static List<Rezervacija> getRezervacijeLista()
        {
            List<Rezervacija> rezervacije = new List<Rezervacija>();
            try
            {
                baza.openConnect();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT * FROM Rezervacija";
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Rezervacija r = new Rezervacija();
                    r.id_rezervacija = int.Parse(reader["id_rezervacija"].ToString());
                    r.id_vozila = int.Parse(reader["id_vozila"].ToString());
                    r.Id_klijenta = int.Parse(reader["id_klijenta"].ToString());
                    r.datumVreme_pocetka = DateTime.Parse(reader["datumVreme_pocetka"].ToString());
                    r.DatumVreme_kraja = DateTime.Parse(reader["datumVreme_kraja"].ToString());
                    r.cena = int.Parse(reader["cena"].ToString());
                    rezervacije.Add(r);
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

            return rezervacije;
        }

        public static List<Rezervacija> getRezervacijeListaBezTrazene(int id)
        {
            List<Rezervacija> rezervacije = new List<Rezervacija>();
            try
            {
                baza.openConnect();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT * FROM Rezervacija WHERE id_rezervacija <>"+id;
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Rezervacija r = new Rezervacija();
                    r.id_rezervacija = int.Parse(reader["id_rezervacija"].ToString());
                    r.id_vozila = int.Parse(reader["id_vozila"].ToString());
                    r.Id_klijenta = int.Parse(reader["id_klijenta"].ToString());
                    r.datumVreme_pocetka = DateTime.Parse(reader["datumVreme_pocetka"].ToString());
                    r.DatumVreme_kraja = DateTime.Parse(reader["datumVreme_kraja"].ToString());
                    r.cena = int.Parse(reader["cena"].ToString());
                    rezervacije.Add(r);
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

            return rezervacije;
        }

        public static List<Rezervacija> getRezervacijeFilter(DateTime t1,DateTime t2)
        {
            List<Rezervacija> rezervacije = new List<Rezervacija>();
            try
            {
                baza.openConnect();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT * FROM Rezervacija WHERE datumVreme_pocetka >= @datumOd AND datumVreme_kraja <= @datumDo";
                cmd.Parameters.AddWithValue("datumOd", t1);
                cmd.Parameters.AddWithValue("datumDo", t2);
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Rezervacija r = new Rezervacija();
                    r.id_rezervacija = int.Parse(reader["id_rezervacija"].ToString());
                    r.id_vozila = int.Parse(reader["id_vozila"].ToString());
                    r.Id_klijenta = int.Parse(reader["id_klijenta"].ToString());
                    r.datumVreme_pocetka = DateTime.Parse(reader["datumVreme_pocetka"].ToString());
                    r.DatumVreme_kraja = DateTime.Parse(reader["datumVreme_kraja"].ToString());
                    r.cena = int.Parse(reader["cena"].ToString());
                    rezervacije.Add(r);
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

            return rezervacije;
        }

        public void InsertReservation()
        {
            int rez = 0;
            try
            {
                baza.openConnect();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "INSERT INTO Rezervacija VALUES(@id_rezervacija,@id_vozila, @id_klijenta, @datumVreme_pocetka, @datumVreme_kraja, @cena)";

                cmd.Parameters.AddWithValue("id_rezervacija", id_rezervacija);
                cmd.Parameters.AddWithValue("id_vozila", id_vozila);
                cmd.Parameters.AddWithValue("id_klijenta", id_klijenta);
                cmd.Parameters.AddWithValue("datumVreme_pocetka", datumVreme_pocetka.ToString("yyyy-MM-dd HH:mm"));
                cmd.Parameters.AddWithValue("datumVreme_kraja", datumVreme_kraja.ToString("yyyy-MM-dd HH:mm"));
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
                MessageBox.Show("Uspesno ste uneli rezervaciju");
            }
        }

        public override string ToString()
        {
            return "Id rez: "+Id_rezervacija + " Id_vozila" + id_vozila + " id_klijenta: "+ id_klijenta;
        }


        //public void InsertRezervacija(Rezervacija rezervacija)
        //{
        //    string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\dzoni\OneDrive\Desktop\RentACarDB.accdb";
        //    using (OleDbConnection connection = new OleDbConnection(connectionString))
        //    {
        //        string query = "INSERT INTO Rezervacija (id_rezervacija, id_vozila, id_klijenta, datumVreme_pocetka, datumVreme_kraja, cena) " +
        //                       "VALUES (@id_rezervacija, @id_vozila, @id_klijenta, @datumVreme_pocetka, @datumVreme_kraja, @cena)";

        //        using (OleDbCommand cmd = new OleDbCommand(query, connection))
        //        {
        //            cmd.Parameters.Add("@id_rezervacija", OleDbType.Integer).Value = id_rezervacija;
        //            cmd.Parameters.Add("@id_vozila", OleDbType.Integer).Value = id_vozila;
        //            cmd.Parameters.Add("@id_klijenta", OleDbType.Integer).Value = id_klijenta;
        //            cmd.Parameters.Add("@datumVreme_pocetka", OleDbType.Date).Value = datumVreme_pocetka;
        //            cmd.Parameters.Add("@datumVreme_kraja", OleDbType.Date).Value = datumVreme_kraja;
        //            cmd.Parameters.Add("@cena", OleDbType.Currency).Value = cena;

        //            connection.Open();
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}




        private int addId()
        {
            int id = 0;
            try
            {
                baza.openConnect();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT MAX(id_rezervacija) FROM Rezervacija";
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
    }
}
