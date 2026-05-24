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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace veritabanı_yine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source =  LAB6-8\\SQLEXPRESS; Initial Catalog = okul; Integrated Security = True; ");

        private void button1_Click(object sender, EventArgs e)
        {
            listeleme();
        }
        void listeleme()
        {
            if(baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "select*from ogrenci3";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "ogrenci3");
                dataGridView1.DataSource = ds.Tables["ogrenci3"];
                baglanti.Close();
            }
        }
        void kaydet()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO ogrenci3 VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                listeleme();
                MessageBox.Show("Kayıt eklendi.");
            }
        }
        void sil()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "DELETE FROM ogrenci3 WHERE TC=@TC";
                cmd.Parameters.AddWithValue("@TC", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                listeleme();
                MessageBox.Show("Kayıt silindi.");
            }
        }
        void güncelle()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "UPDATE ogrenci3 SET AdSoyad = @a1, TC = @a2, Telefon = @a3, SinifSube = @a4";
                cmd.Parameters.AddWithValue("@a1", textBox1.Text);
                cmd.Parameters.AddWithValue("@a2", textBox2.Text);
                cmd.Parameters.AddWithValue("@a3", textBox3.Text);
                cmd.Parameters.AddWithValue("@a4", textBox4.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                listeleme();
                MessageBox.Show("Kayıt güncellendi.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kaydet();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sil();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            güncelle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
