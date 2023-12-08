using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace öğrenci_kayıtt
{
    public partial class kayıtekle : Form
    {
        public kayıtekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Table_1(kullanıcıadı,sifre,ad,soyad,numara) values(@1,@2,@3,@4,@5)", connection);
            cmd.Parameters.AddWithValue("@1", kadi.Text);
            cmd.Parameters.AddWithValue("@2", sifre.Text);
            cmd.Parameters.AddWithValue("@3", textbox1.Text);
            cmd.Parameters.AddWithValue("@4", textbox2.Text);
            cmd.Parameters.AddWithValue("@5", textbox3.Text);
            cmd.EndExecuteNonQuery();
            connection.Close();
            string ad=textBox1.Text;
            string soyad=textBox2.Text;
            

            string num=textBox3.Text;
            int numara=int.Parse(num);

            label4.Text = "kayıt başarılı";

         
        }

        private void gor_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;


            string num = textBox3.Text;
            int numara = int.Parse(num);

            label4.Text = "kayıt görüntüleniyor";


            textBox4.Text=(ad+" " + soyad+" " + numara);



        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void kayıtekle_Load(object sender, EventArgs e)
        {

        }
    }
}
