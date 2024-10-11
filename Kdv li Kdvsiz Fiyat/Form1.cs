using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kdv_li_Kdvsiz_Fiyat
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

        private void button1_Click(object sender, EventArgs e)
        {
            string Ürün;
            double sonuc;
            double sonuc2;
            Double KDV1, KDV2;
            Int32 Vergisiz;
            Ürün = textBox1.Text;
            KDV1 = Convert.ToDouble(textBox3.Text);
            KDV2 = Convert.ToDouble(textBox4.Text);
            Vergisiz=Convert.ToInt32(textBox2.Text);
            sonuc = (Vergisiz * KDV1) / 100;
            sonuc2 = (Vergisiz * KDV2) / 100;
            listBox1.Items.Add(sonuc);
            listBox1.Items.Add(sonuc2);
            listBox1.Items.Add(Ürün + " " + "KDV1:" + " " + KDV1 + " " + sonuc + "KDV2:" + " " + KDV2 + " " + sonuc2 );

        }
    }
}
