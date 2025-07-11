namespace MyHomeWork1_C_
{
    partial class GameRandomNumber
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            Random = new Button();
            label1 = new Label();
            score = new Label();
            label2 = new Label();
            select = new Label();
            label3 = new Label();
            oldRandom = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(104, 46);
            button1.Name = "button1";
            button1.Size = new Size(158, 115);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(363, 46);
            button2.Name = "button2";
            button2.Size = new Size(158, 115);
            button2.TabIndex = 0;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(104, 187);
            button3.Name = "button3";
            button3.Size = new Size(158, 115);
            button3.TabIndex = 0;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(363, 187);
            button4.Name = "button4";
            button4.Size = new Size(158, 115);
            button4.TabIndex = 0;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Random
            // 
            Random.Location = new Point(208, 358);
            Random.Name = "Random";
            Random.Size = new Size(203, 60);
            Random.TabIndex = 1;
            Random.Text = "Random";
            Random.UseVisualStyleBackColor = true;
            Random.Click += Random_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Chartreuse;
            label1.Location = new Point(354, 335);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 2;
            label1.Text = "Score : ";
            // 
            // score
            // 
            score.AutoSize = true;
            score.Location = new Point(406, 335);
            score.Name = "score";
            score.Size = new Size(17, 20);
            score.TabIndex = 2;
            score.Text = "0";
            score.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 305);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 2;
            label2.Text = "Select : ";
            // 
            // select
            // 
            select.AutoSize = true;
            select.Location = new Point(268, 305);
            select.Name = "select";
            select.Size = new Size(17, 20);
            select.TabIndex = 2;
            select.Text = "0";
            select.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(202, 335);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 2;
            label3.Text = "Old Random : ";
            label3.Click += label3_Click;
            // 
            // oldRandom
            // 
            oldRandom.AutoSize = true;
            oldRandom.Location = new Point(312, 335);
            oldRandom.Name = "oldRandom";
            oldRandom.Size = new Size(17, 20);
            oldRandom.TabIndex = 2;
            oldRandom.Text = "0";
            oldRandom.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 450);
            Controls.Add(oldRandom);
            Controls.Add(select);
            Controls.Add(score);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Random);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button Random;
        private Label label1;
        private Label score;
        private Label label2;
        private Label select;
        private Label label3;
        private Label oldRandom;
    }
}
