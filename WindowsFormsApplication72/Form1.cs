using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication72
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBcrud yukle = new DBcrud();
            DataTable tbl = new DataTable();

            //tbl.Load(yukle.bolumliste());
            tbl = yukle.bolumliste();
            //for (int i = 0; i < tbl.Rows.Count; i++)
            //{
            //comboBox1.Items.Add(tbl.Rows[i]["Ad"]);
            //comboBox1.Inde
            //}
            comboBox1.DataSource = tbl;
            comboBox1.DisplayMember = "Ad";
            comboBox1.ValueMember = "Kod";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text==textBox7.Text)
            {
            Baglanti b = new Baglanti();
            b.yol.Open();
            SqlCommand komut = new SqlCommand("Insert Into TblOgrenciler Values (@a,@b,@c,@d,@e,@f) ",b.yol);
            komut.Parameters.AddWithValue("@a",textBox1.Text);
            komut.Parameters.AddWithValue("@b", textBox2.Text);
            komut.Parameters.AddWithValue("@c", textBox3.Text);
            komut.Parameters.AddWithValue("@d", textBox4.Text);
            komut.Parameters.AddWithValue("@e", textBox5.Text);
            komut.Parameters.AddWithValue("@f", comboBox1.SelectedValue);
            komut.ExecuteNonQuery();
            b.yol.Close();
            }
            else
            {
                label8.Text = "Girilen Şifreler Aynı Değil";
            }

        }
    }
}
