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

namespace SQLDerleyici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalistir_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("server=localhost; Initial Catalog = " + CmbVeritabani.Text +" ;Integrated Security=SSPI");
            string sorgu = richTextBox1.Text;

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception)
            {
                MessageBox.Show("Sorgunuzu kontrol ediniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void BtnEkleSilGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("server=localhost; Initial Catalog = " + CmbVeritabani.Text + " ;Integrated Security=SSPI");
            string sorgu = richTextBox1.Text;
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();

                SqlDataAdapter da = new SqlDataAdapter("Select * from '" + CmbVeritabani.Text + "'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception)
            {
                MessageBox.Show("Sorgunuzu kontrol ediniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        void veritabani()
        {
            SqlConnection baglanti = new SqlConnection("server=localhost; Initial Catalog = " + CmbVeritabani.Text + " ;Integrated Security=SSPI");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from sys.databases", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbVeritabani.Items.Add(dr[0].ToString());
            }
            baglanti.Close();

        }
        void tablolar()
        {
            SqlConnection baglanti = new SqlConnection("server=localhost; Initial Catalog = " + CmbVeritabani.Text + " ;Integrated Security=SSPI");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from sys.Tables ", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbTablolar.Items.Add(dr[0].ToString());
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            veritabani();
        }

        private void CmbVeritabani_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbTablolar.Items.Clear();
            tablolar();
        }

        private void CmbTablolar_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "Select * from " + " " + CmbTablolar.Text;
        }
    }
}
