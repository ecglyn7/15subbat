using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace salam

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ErrorProvider ep = new ErrorProvider();
        int y1, y2, p1, p2;
        private void txtbox_y1_Validating(object sender, CancelEventArgs e)
        {
            
            try
            {
                if (string.IsNullOrEmpty(txtbox_y1.Text))
                {
                    e.Cancel = true;
                    ep.SetError(txtbox_y1, "Boş bırakmayınız");

                }
                else
                {    y1 = Convert.ToInt32(txtbox_y1.Text);
                     ep.SetError(txtbox_y1, "");
                     if (y1>100||y1<0)
                     {
                        e.Cancel = true;
                        ep.SetError(txtbox_y1, "0 - 100 arasında değer giriniz.");
                     }
                     else
                     {
                       
                        ep.SetError(txtbox_y1, "");
                     }
                }
     
            }
            catch 
            {

                ep.SetError(txtbox_y1, "Sayısal Değer Giriniz!");
            }
        }

        private void txtbox_isim_Validating(object sender, CancelEventArgs e)
        {
            if (txtbox_isim.Text == "")
            {
                e.Cancel = true;
                ep.SetError(txtbox_isim, "Adı ve soyadı giriniz.");
            }
            else
            {
                ep.SetError(txtbox_isim, "");
            }
        }
        int toplam;
        private void btn_ortalama_Click(object sender, EventArgs e)
        {
            label6.Text = "Ortalama:";
            toplam = (y1 + y1 + p1 + p2) / 4;
            label6.Text += toplam;
        }

        private void txtbox_y2_Validating(object sender, CancelEventArgs e)
        {
            
            try
            {
                if (string.IsNullOrEmpty(txtbox_y2.Text))
                {
                    e.Cancel = true;
                    ep.SetError(txtbox_y2, "Boş bırakmayınız");

                }
                else
                {
                    y2 = Convert.ToInt32(txtbox_y2.Text);
                    ep.SetError(txtbox_y2, "");
                    if (y2 > 100 || y2 < 0)
                    {
                        e.Cancel = true;
                        ep.SetError(txtbox_y2, "0 - 100 arasında değer giriniz.");
                    }
                    else
                    {

                        ep.SetError(txtbox_y2, "");
                    }
                }
            }
            catch
            {
                ep.SetError(txtbox_y2,"Sayısal Değer Giriniz!");
            }
        }

        private void txtbox_p1_Validating(object sender, CancelEventArgs e)
        {
         
            try
            {
                if (string.IsNullOrEmpty(txtbox_p1.Text))
                {
                    e.Cancel = true;
                    ep.SetError(txtbox_p1, "Boş bırakmayınız");

                }
                else
                {
                    p1 = Convert.ToInt32(txtbox_p1.Text);
                    ep.SetError(txtbox_p1, "");
                    if (p1 > 100 || p1 < 0)
                    {
                        e.Cancel = true;
                        ep.SetError(txtbox_p1, "0 - 100 arasında değer giriniz.");
                    }
                    else
                    {

                        ep.SetError(txtbox_p1, "");
                    }
                }
            }
            catch
            {
                ep.SetError(txtbox_p1, "Sayısal Değer Giriniz!");
            }
        }

        private void txtbox_p2_Validating(object sender, CancelEventArgs e)
        {
         
            try
            {
                if (string.IsNullOrEmpty(txtbox_p2.Text))
                {
                    e.Cancel = true;
                    ep.SetError(txtbox_p2, "Boş bırakmayınız");

                }
                else
                {
                    p2 = Convert.ToInt32(txtbox_p2.Text);
                    ep.SetError(txtbox_p2, "");
                    if (p2 > 100 || p2 < 0)
                    {
                        e.Cancel = true;
                        ep.SetError(txtbox_p2, "0 - 100 arasında değer giriniz.");
                    }
                    else
                    {

                        ep.SetError(txtbox_p2, "");
                    }
                }
            }
            catch
            {
                ep.SetError(txtbox_p2, "Sayısal Değer Giriniz!");
            }
        }
    }
}
