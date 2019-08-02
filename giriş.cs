using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kullanıcı
{
    
    public partial class giriş : Form
    {
        int x2 = Form1.x;
        public giriş()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
           
            int ücret = 0;
            int fordg = 80;
            int golf = 120;
            int clio = 70;
            int k = Convert.ToInt32(textBox1.Text);
            int fordücret = fordg * k+500;
            int golfücret = golf * k+1000;
            int clioücret = clio * k+400;


           
                if (radioButton1.Checked == true)
                {
                
                    ücret = fordücret ;
                    label18.Text ="normal fiyatı"+ ücret.ToString();
                }
                if (radioButton2.Checked==true)
                {
                
                    ücret = golfücret;
                    label18.Text ="normal fiyatı"+ ücret.ToString();
                }
                if (radioButton3.Checked==true)
                {
                
                    ücret = clioücret;
                    label18.Text ="normal fiyatı"+ ücret.ToString();
                }
            int indirim = ücret * 1 / 10;
            if (x2==1)
            {
                int fiyat = ücret - indirim;
                label19.Text ="Size özel indirimli fiyatı " +fiyat;
                label19.Visible = true;
            }
            else
            {
                label19.Text = "Kayıt olup indirimden yararlanabilirsiniz";
                label19.Visible = true;
            }
             

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi1=rastgele.Next(0,9);
            int sayi2 = rastgele.Next(10,100);
            int harfdegeri = rastgele.Next(65, 91);
            char karakter;
            karakter = Convert.ToChar(harfdegeri);
            MessageBox.Show(sayi1.ToString()+karakter+sayi2.ToString() + "    bu kod ile ofisimizden aracınızı kiralayabilirsiniz!");
        }
    }
    }

