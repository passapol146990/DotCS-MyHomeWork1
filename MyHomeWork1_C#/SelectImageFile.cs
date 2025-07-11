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
    public partial class SelectImageFile : Form
    {
        public SelectImageFile()
        {
            InitializeComponent();
        }

        private async void SelectPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                progressBar1.Visible = true;
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 100;
                progressBar1.Value = 0;

                for (int i = 0; i <= 100; i += 5)
                {
                    progressBar1.Value = i;
                    await Task.Delay(20);
                }

                try
                {
                    SelectPicture.Image = new Bitmap(openFileDialog.FileName);
                    SelectPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    progressBar1.Value = 100;
                    await Task.Delay(200);
            }
        }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
