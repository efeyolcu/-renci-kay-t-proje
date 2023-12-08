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

namespace öğrenci_kayıtt
{
    public partial class Form1 : Form
    {
        
        
         
        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2JR0BBO\\SQLEXPRESS;Initial Catalog=okulveritabanı;Integrated Security=True");
       
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Table_1(kullanıcıadı,sifre,ad,soyad,numara) values(@1,@2,@3,@4,@5)" ,connection);
            cmd.Parameters.AddWithValue("@1", kadi.Text);
            cmd.Parameters.AddWithValue("@2", sifre.Text);
            cmd.Parameters.AddWithValue("@3", textbox1.Text);
            cmd.Parameters.AddWithValue("@4", textbox2.Text);
            cmd.Parameters.AddWithValue("@5", textbox3.Text);
            cmd.EndExecuteNonQuery();
            connection.Close();
            string kullanıcıadı = kadi.Text;
          
          
            if (kadi.Text == "efe" && sifre.Text=="1212")
            {
                kayıtekle ekle = new kayıtekle();
                ekle.Show();
                this.Hide();
            }
           
            else
            {
                MessageBox.Show("hatalı girdiniz!!!");
                kadi.Clear();
                sifre.Clear();
                kadi.Focus();
            }
            SqlCommand command = new SqlCommand("Select *fromkayıt", connection);
            SqlDataReader reader = command.ExecuteReader();
        }
    }
}
