using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication72
{
    
    class DBcrud
    {
        Baglanti b = new Baglanti();
        public DataTable bolumliste ()
        {
            DataTable liste = new DataTable();
            b.yol.Open();
            SqlCommand komut = new SqlCommand("select * from TblBolumler",b.yol);
            SqlDataReader dr = komut.ExecuteReader();
            liste.Load(dr);
            b.yol.Close();
            return liste;
        }
    }
}
