namespace MyHomeWork1_C_
{
    partial class SelectImageFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SelectPicture = new PictureBox();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)SelectPicture).BeginInit();
            SuspendLayout();
            // 
            // SelectPicture
            // 
            SelectPicture.BackColor = SystemColors.ActiveBorder;
            SelectPicture.BorderStyle = BorderStyle.FixedSingle;
            SelectPicture.Cursor = Cursors.Hand;
            SelectPicture.Location = new Point(181, 25);
            SelectPicture.Name = "SelectPicture";
            SelectPicture.Size = new Size(403, 274);
            SelectPicture.TabIndex = 0;
            SelectPicture.TabStop = false;
            SelectPicture.Click += SelectPicture_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(181, 332);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(403, 29);
            progressBar1.TabIndex = 1;
            progressBar1.Click += progressBar1_Click;
            // 
            // SelectImageFile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(SelectPicture);
            Name = "SelectImageFile";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)SelectPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox SelectPicture;
        private ProgressBar progressBar1;
    }
}