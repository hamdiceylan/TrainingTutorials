using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int tutar = Convert.ToInt32(txtTutar.Text);
            int kdvYuzdesi = Convert.ToInt32(txtKdv.Text);
            lblSonuc.Text = KdvHesapla(tutar, kdvYuzdesi).ToString();
       }
        private void button1_Click(object sender, EventArgs e)
        {
            int tutar = Convert.ToInt32(txtTutar.Text);
            int kdvYuzdesi = Convert.ToInt32(txtKdv.Text);
            lblOzelSonuc.Text = (KdvHesapla(tutar, kdvYuzdesi) + 50).ToString();
        }
        public int KdvHesapla(int Tutar, int KdvYuzdesi)
        {
            int kdvMiktari = (Tutar * KdvYuzdesi) / 100;
            return kdvMiktari + Tutar;
        }
    }
}
