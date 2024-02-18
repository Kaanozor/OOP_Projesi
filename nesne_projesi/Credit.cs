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
    public partial class Credit : Form
    {
        public Credit()
        {
            InitializeComponent();
        }

        long _creditNumber = 1111111111;
        int _creditCvc = 111;
        int _creditExp = 1111;


        private void pay_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            List<items> item3 = new List<items>();
            item3 = items.ite;



            
            

            long creditnumber = Convert.ToInt64(creditNumber.Text);
            int creditcvc = Convert.ToInt32(cvc.Text);
            int creditexp = Convert.ToInt32(exp.Text);

            
            if(_creditCvc == creditcvc && _creditExp==creditexp && _creditNumber==creditnumber)
            {
                foreach (var item in item3)
                {
                    database.Updating(Form1.currentId,item.urunID);
                    MessageBox.Show("Ürünler Kargoya verilmiştir.");
                }

            }


            
        }

        private void creditNumber_Click(object sender, EventArgs e)
        {
            creditNumber.Clear();
        }

        private void exp_Click(object sender, EventArgs e)
        {
            exp.Clear();
        }

        private void cvc_Click(object sender, EventArgs e)
        {
            cvc.Clear();
        }
    }
}
