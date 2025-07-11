namespace MyHomeWork1_C_
{
    partial class POS
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
            components = new System.ComponentModel.Container();
            LableType = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            ComboBoxType = new ComboBox();
            LabelName = new Label();
            ComboBoxName = new ComboBox();
            PriceInput = new NumericUpDown();
            QuanlityInput = new NumericUpDown();
            DateTimeInput = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            Order = new Button();
            ((System.ComponentModel.ISupportInitialize)PriceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QuanlityInput).BeginInit();
            SuspendLayout();
            // 
            // LableType
            // 
            LableType.AutoSize = true;
            LableType.Location = new Point(81, 31);
            LableType.Name = "LableType";
            LableType.Size = new Size(51, 20);
            LableType.TabIndex = 0;
            LableType.Text = "Type : ";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // ComboBoxType
            // 
            ComboBoxType.FormattingEnabled = true;
            ComboBoxType.Location = new Point(157, 28);
            ComboBoxType.Name = "ComboBoxType";
            ComboBoxType.Size = new Size(250, 28);
            ComboBoxType.TabIndex = 3;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(81, 81);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(60, 20);
            LabelName.TabIndex = 0;
            LabelName.Text = "Name : ";
            // 
            // ComboBoxName
            // 
            ComboBoxName.FormattingEnabled = true;
            ComboBoxName.Location = new Point(157, 78);
            ComboBoxName.Name = "ComboBoxName";
            ComboBoxName.Size = new Size(250, 28);
            ComboBoxName.TabIndex = 3;
            // 
            // PriceInput
            // 
            PriceInput.DecimalPlaces = 2;
            PriceInput.Location = new Point(157, 133);
            PriceInput.Name = "PriceInput";
            PriceInput.Size = new Size(250, 27);
            PriceInput.TabIndex = 4;
            // 
            // QuanlityInput
            // 
            QuanlityInput.Location = new Point(157, 188);
            QuanlityInput.Name = "QuanlityInput";
            QuanlityInput.Size = new Size(150, 27);
            QuanlityInput.TabIndex = 4;
            // 
            // DateTimeInput
            // 
            DateTimeInput.Location = new Point(157, 253);
            DateTimeInput.Name = "DateTimeInput";
            DateTimeInput.Size = new Size(250, 27);
            DateTimeInput.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 135);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Price : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 190);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 0;
            label2.Text = "Quanlity : ";
            // 
            // Order
            // 
            Order.Location = new Point(180, 329);
            Order.Name = "Order";
            Order.Size = new Size(180, 55);
            Order.TabIndex = 6;
            Order.Text = "Order";
            Order.UseVisualStyleBackColor = true;
            Order.Click += Order_Click;
            // 
            // POS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 450);
            Controls.Add(Order);
            Controls.Add(DateTimeInput);
            Controls.Add(QuanlityInput);
            Controls.Add(PriceInput);
            Controls.Add(ComboBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LabelName);
            Controls.Add(ComboBoxType);
            Controls.Add(LableType);
            Name = "POS";
            Text = "POS";
            Load += POS_Load;
            ((System.ComponentModel.ISupportInitialize)PriceInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)QuanlityInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LableType;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ComboBox ComboBoxType;
        private Label LabelName;
        private ComboBox ComboBoxName;
        private NumericUpDown PriceInput;
        private NumericUpDown QuanlityInput;
        private DateTimePicker DateTimeInput;
        private Label label1;
        private Label label2;
        private Button Order;
    }
}