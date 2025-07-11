namespace MyHomeWork1_C_
{
    partial class ProgrameAddInformation
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
            label1 = new Label();
            label2 = new Label();
            ButtonAdd = new Button();
            button_insert_index = new Button();
            button_remove = new Button();
            button_remove_idx = new Button();
            button_select_up = new Button();
            button_select_down = new Button();
            input_index = new TextBox();
            input_value = new TextBox();
            listBox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 32);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "index : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 64);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 0;
            label2.Text = "value : ";
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(46, 110);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(240, 47);
            ButtonAdd.TabIndex = 2;
            ButtonAdd.Text = "Add";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAddValue;
            // 
            // button_insert_index
            // 
            button_insert_index.Location = new Point(46, 163);
            button_insert_index.Name = "button_insert_index";
            button_insert_index.Size = new Size(240, 47);
            button_insert_index.TabIndex = 2;
            button_insert_index.Text = "Insert index";
            button_insert_index.UseVisualStyleBackColor = true;
            button_insert_index.Click += button_insert_index_Click;
            // 
            // button_remove
            // 
            button_remove.Location = new Point(46, 216);
            button_remove.Name = "button_remove";
            button_remove.Size = new Size(240, 47);
            button_remove.TabIndex = 2;
            button_remove.Text = "remove";
            button_remove.UseVisualStyleBackColor = true;
            button_remove.Click += button_remove_Click;
            // 
            // button_remove_idx
            // 
            button_remove_idx.Location = new Point(46, 269);
            button_remove_idx.Name = "button_remove_idx";
            button_remove_idx.Size = new Size(240, 47);
            button_remove_idx.TabIndex = 2;
            button_remove_idx.Text = "remove index";
            button_remove_idx.UseVisualStyleBackColor = true;
            button_remove_idx.Click += button_remove_idx_Click;
            // 
            // button_select_up
            // 
            button_select_up.Location = new Point(46, 322);
            button_select_up.Name = "button_select_up";
            button_select_up.Size = new Size(240, 47);
            button_select_up.TabIndex = 2;
            button_select_up.Text = "Select Up";
            button_select_up.UseVisualStyleBackColor = true;
            button_select_up.Click += button_select_up_Click;
            // 
            // button_select_down
            // 
            button_select_down.Location = new Point(46, 375);
            button_select_down.Name = "button_select_down";
            button_select_down.Size = new Size(240, 47);
            button_select_down.TabIndex = 2;
            button_select_down.Text = "Select down";
            button_select_down.UseVisualStyleBackColor = true;
            button_select_down.Click += button_select_down_Click;
            // 
            // input_index
            // 
            input_index.Location = new Point(108, 29);
            input_index.Name = "input_index";
            input_index.Size = new Size(178, 27);
            input_index.TabIndex = 3;
            // 
            // input_value
            // 
            input_value.Location = new Point(107, 61);
            input_value.Name = "input_value";
            input_value.Size = new Size(179, 27);
            input_value.TabIndex = 3;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(317, 32);
            listBox.Name = "listBox";
            listBox.Size = new Size(454, 384);
            listBox.TabIndex = 4;
            // 
            // ProgrameAddInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox);
            Controls.Add(input_value);
            Controls.Add(input_index);
            Controls.Add(button_select_down);
            Controls.Add(button_select_up);
            Controls.Add(button_remove_idx);
            Controls.Add(button_remove);
            Controls.Add(button_insert_index);
            Controls.Add(ButtonAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProgrameAddInformation";
            Text = "ProgrameAddInformation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button ButtonAdd;
        private Button button_insert_index;
        private Button button_remove;
        private Button button_remove_idx;
        private Button button_select_up;
        private Button button_select_down;
        private TextBox input_index;
        private TextBox input_value;
        private ListBox listBox;
    }
}