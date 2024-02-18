using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nesne_projesi
{
    public partial class Sepet : Form
    {
        List<items> se2 = new List<items>();
        public float SubTotal = 0.0f;
        public Sepet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("index" + listBox1.SelectedIndex);
            if (listBox1.SelectedIndex >= 0)
                se2.RemoveAt(listBox1.SelectedIndex);
            else
            {
                MessageBox.Show("olmadı");
            }
            listBox1.Items.Remove(listBox1.SelectedItem);

            SubTotal = 0.0f;
            foreach (var item in se2)
            {
                SubTotal += item.amount;
            }
            tutar.Text = SubTotal.ToString();   //Ödeme.Vergilendir(SubTotal).ToString();




            items.ite = se2;
        }

        

        private void tutar_Click(object sender, EventArgs e)
        {

        }

        private void Sepet_Load(object sender, EventArgs e)
        {
            se2 = items.ite;

            MessageBox.Show("s");

            foreach (var item in se2)
            {
                listBox1.Items.Add(item.urunAd.ToString() + "   " + item.amount.ToString() + " tl");
            }



            foreach (var item in se2)
            {
                SubTotal += item.amount;
            }


            tutar.Text = "Tutar = " + SubTotal.ToString();            //Ödeme.Vergilendir(SubTotal);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
        }
    }
}
