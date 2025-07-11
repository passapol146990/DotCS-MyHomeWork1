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
    public partial class ProgrameAddInformation : Form
    {
        public ProgrameAddInformation()
        {
            InitializeComponent();
        }

        private void ButtonAddValue(object sender, EventArgs e)
        {
            listBox.Items.Add(input_value.Text);
        }

        private void button_insert_index_Click(object sender, EventArgs e)
        {
            int idx = Convert.ToInt32(input_index.Text);
            string value = Convert.ToString(input_value.Text);
            listBox.Items.Insert(idx, value);
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            listBox.Items.Remove(input_value.Text);
        }

        private void button_remove_idx_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(listBox.Items.Count);
            int idx = Convert.ToInt32(input_index.Text);
            if (count > 0 && idx <= count)
            {
                listBox.Items.RemoveAt(idx - 1);
                input_index.Text = "";
            }
        }

        private void button_select_up_Click(object sender, EventArgs e)
        {
            int i = listBox.SelectedIndex;

            if (i > 0)
            {
                object item = listBox.SelectedItem;
                listBox.Items.RemoveAt(i);
                listBox.Items.Insert(i - 1, item);
                listBox.SetSelected(i - 1, true);
            }
        }

        private void button_select_down_Click(object sender, EventArgs e)
        {
            int i = listBox.SelectedIndex;
            if (i < listBox.Items.Count - 1 && i != -1)
            {
                object item = listBox.SelectedItem;
                listBox.Items.RemoveAt(i);
                listBox.Items.Insert(i + 1, item);
                listBox.SetSelected(i + 1, true);
            }
        }
    }
}
