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
    
    public partial class Form1 : Form
    {
        public static int x=0;
           
        public Form1()
        {
            InitializeComponent();
        }
       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kayıtol form = new kayıtol();
            form.Show();
        }

        SqlConnection baglan = new SqlConnection("Data Source=./;Initial Catalog=kullanıcı;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
           
        {
            
            try
            {
                x = 1;
                baglan.Open();
                string sql = "select * From kbil where isim=@ismi and sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("ismi", textBox1.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", textBox2.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglan);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count>0)
                {
                    giriş fr = new giriş();
                    fr.Show();
                    this.Hide();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("hatalı giriş");
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            x = 2;
            giriş frc = new giriş();
            frc.Show();
        }
    }
}
