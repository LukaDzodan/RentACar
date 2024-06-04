using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVPDrugiProjekat
{
    public class Baza
    {
        OleDbConnection conn;

        public Baza(string connString)
        {
            conn = new OleDbConnection();
            Conn.ConnectionString = connString;
        }
        public OleDbConnection Conn { get => conn; set => conn = value; }

        public void openConnect()
        {
            if (conn != null)
                conn.Open();
        }
        public void closeConnect()
        {
            if (conn != null)
                conn.Close();
        }
    }
}
