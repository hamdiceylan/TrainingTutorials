using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3, sayi4;
            int[] dizi = new int[4];
            sayi1 = 5;
            dizi[0] = 1;
            dizi[1] = 2;
            dizi[2] = 3;
            dizi[3] = 4;

            string[] gunler = new string[7];
            gunler[0] = "Pazartesi";
            gunler[1] = "Salı";
            gunler[2] = "Çarşamba";
            gunler[3] = "Perşembe";
            gunler[4] = "Cuma";
            gunler[5] = "Cumartesi";
            gunler[6] = "Pazar";

            for (int i = 0; i <7 ; i++)
            {
                label1.Text += gunler[i];
            }

        }
    }
}
