using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHomeWork1_C_
{
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }

        private void POS_Load(object sender, EventArgs e)
        {
            string[] TYPE = { "Coffee" };
            string[] Name = { "Capu", "Arabus" };
            foreach (string type in TYPE)
            {
                ComboBoxType.Items.Add(type);
            }

            foreach (string name in Name)
            {
                ComboBoxName.Items.Add(name);
            }


        }

        private void Order_Click(object sender, EventArgs e)
        {
            int quanlity = Convert.ToInt32(QuanlityInput.Value);
            int price = Convert.ToInt32(PriceInput.Value);

            string header = "Confirm";
            string body = "Do you confirm you Order Type is "+ComboBoxType.Text;

            body += "\nName product is "+ComboBoxName.Text;
            body += "\nPrice is " + price;
            body += "\nQuanlity is " + quanlity;
            body += "\nTotal is " + price*quanlity;
            body += "\nDate order is " + DateTimeInput.Value;

            MessageBox.Show(body,header,MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
        }
    }
}
