using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace TVPDrugiProjekat
{
    public class Vozilo
    {
        static RentACarDBDataSet ds = new RentACarDBDataSet();
        static RentACarDBDataSetTableAdapters.VoziloTableAdapter da = new RentACarDBDataSetTableAdapters.VoziloTableAdapter();


        private static string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\dzoni\OneDrive\Desktop\RentACarDB.accdb";
        static Baza baza = new Baza(connString);

        private int id_vozila;
        private int id_kategorije;
        private string naziv;
        private string marka;
        private string model;
        private int godina_proizvodnje;
        private int cena_po_satu;

        public Vozilo(int id_kategorije, string naziv, string marka, string model, int godina_proizvodnje, int cena_po_satu)
        {
            ds = new RentACarDBDataSet();
            da = new RentACarDBDataSetTableAdapters.VoziloTableAdapter();
            this.id_vozila = addId();
            this.id_kategorije = id_kategorije;
            this.naziv = naziv;
            this.marka = marka;
            this.model = model;
            this.godina_proizvodnje = godina_proizvodnje;
            this.cena_po_satu = cena_po_satu;

        }

        public Vozilo()
        {
           
        }

        public int Id_vozila { get => id_vozila; set => id_vozila = value; }
        public int Id_kategorije { get => id_kategorije; set => id_kategorije = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public int Godina_proizvodnje { get => godina_proizvodnje; set => godina_proizvodnje = value; }
        public int Cena_po_satu { get => cena_po_satu; set => cena_po_satu = value; }

        public void insertVozilo()
        {
            int rez = 0;
            try
            {
                baza.openConnect();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "INSERT INTO Vozilo VALUES (@id_vozila,@id_kategorije,@naziv,@marka,@model,@godina_proizvodnje,@cena_po_satu)";

                cmd.Parameters.AddWithValue("id_vozila", id_vozila);
                cmd.Parameters.AddWithValue("id_kategorije", id_kategorije);
                cmd.Parameters.AddWithValue("naziv", naziv);
                cmd.Parameters.AddWithValue("marka", marka);
                cmd.Parameters.AddWithValue("model", model);
                cmd.Parameters.AddWithValue("godina_proizvodnje", godina_proizvodnje);
                cmd.Parameters.AddWithValue("cena_po_satu", cena_po_satu);

                rez = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                baza.closeConnect();
            }
            if (rez != 0)
            {
                MessageBox.Show("Uspesno ste dodali vozilo!");
            }
        }


        public static DataTable getVozila()
        {
            List<Vozilo> vozila = new List<Vozilo>();
            da.Fill(ds.Vozilo);
            DataTable lista = ds.Vozilo.Copy();
            return lista;
        }
        public static List<Vozilo> getVozilaLista()
        {
            List<Vozilo> vozila = new List<Vozilo>();
            try
            {
                baza.openConnect();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT * FROM Vozilo";
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Vozilo v = new Vozilo();
                    v.id_vozila = int.Parse(reader["id_vozila"].ToString());
                    v.id_kategorije = int.Parse(reader["id_kategorije"].ToString());
                    v.naziv = reader["naziv"].ToString();
                    v.marka = reader["marka"].ToString();
                    v.model = reader["model"].ToString();
                    v.godina_proizvodnje = int.Parse(reader["godina_proizvodnje"].ToString());
                    v.cena_po_satu = int.Parse(reader["cena_po_satu"].ToString());

                    vozila.Add(v);
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

            return vozila;
        }

        public override string ToString()
        {
            return naziv;
        }

        public static Vozilo getNajcesceVozilo()
        {
            Vozilo v = new Vozilo();
            int id = 0;
            try
            {
                baza.openConnect();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT TOP 1 id_vozila, count(*) as occurence FROM Rezervacija GROUP BY id_vozila ORDER BY count(*) DESC";
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id = int.Parse(reader["id_vozila"].ToString());
                }
                //MessageBox.Show("Id je:" + id);

                reader.Close();

                cmd.CommandText = "SELECT * FROM Vozilo WHERE id_vozila="+id;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    v.id_vozila = int.Parse(reader["id_vozila"].ToString());
                    v.id_kategorije = int.Parse(reader["id_kategorije"].ToString());
                    v.naziv = reader["naziv"].ToString();
                    v.marka = reader["marka"].ToString();
                    v.model = reader["model"].ToString();
                    v.godina_proizvodnje = int.Parse(reader["godina_proizvodnje"].ToString());
                    v.cena_po_satu = int.Parse(reader["cena_po_satu"].ToString());

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

            return v;
        }

        private int addId()
        {
            int id = 0;
            try
            {
                baza.openConnect();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Conn;
                cmd.CommandText = "SELECT MAX(id_vozila) FROM Vozilo";

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

