using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKarekok_Click(object sender, EventArgs e)
        {
            //karekök hesaplama
            int sayi;
            double sonuc;
            sayi = int.Parse(txtSayi.Text);

            sonuc=Math.Sqrt(sayi);

            txtSonuc.Text = sonuc.ToString();
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = Math.PI.ToString();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = Math.E.ToString();
        }

        private void btnUs_Click(object sender, EventArgs e)
        {
            int sayi;
            double sonuc;
            sayi = int.Parse(txtSayi.Text);

            sonuc = Math.Pow(sayi, 3);
                       
            txtSonuc.Text = sonuc.ToString();
        }

        private void btnMutlak_Click(object sender, EventArgs e)
        {
            double sayi;
            
            sayi = double.Parse(txtSayi.Text);

            txtSonuc.Text = Math.Abs(sayi).ToString();           

        }

        private void btnAsagi_Click(object sender, EventArgs e)
        {
            double sayi;
            sayi = double.Parse(txtSayi.Text);
            txtSonuc.Text = Math.Floor(sayi).ToString();         

        }

        private void btnYukarı_Click(object sender, EventArgs e)
        {
            double sayi;
            sayi = double.Parse(txtSayi.Text);
            txtSonuc.Text = Math.Ceiling(sayi).ToString();
        }
    }
}
