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

namespace kullanıcı
{
    public partial class kayıtol : Form
    {
        
        public kayıtol()
        {
            InitializeComponent();
        }

        void verilerimigöster()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *From kbil", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            baglanti.Close();

        }
        SqlConnection baglanti = new SqlConnection("Data Source=./;Initial Catalog=kullanıcı;Integrated Security=True");
        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text==textBox3.Text)
            {
                baglanti.Open();
                SqlCommand komu = new SqlCommand("Insert Into kbil(isim,sifre,eposta) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text + "','" + textBox4.Text.ToString() + "')", baglanti);
                komu.ExecuteNonQuery();
                baglanti.Close();
                verilerimigöster();
                MessageBox.Show("Kaydınız oluşturuldu");
                this.Hide();
            }
            else
            {
                MessageBox.Show("şifreler uyuşmuyor!!");
            }
            
            

        }
        

        private void kayıtol_Load(object sender, EventArgs e)
        {

             
           

        }
    
    }
}
