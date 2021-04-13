using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication72
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool cevap;
            DBcrud kayit = new DBcrud();
            cevap=kayit.uyevarmi(textBox1.Text, textBox2.Text);
            if (cevap==true)
            {
                MessageBox.Show("Giriş Başarılı");
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
        }
    }
}
