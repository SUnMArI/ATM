namespace ATM
{
    partial class Transaction
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
            moneyBox = new TextBox();
            Column5 = new TextBox();
            Column4 = new TextBox();
            Column3 = new TextBox();
            Column2 = new TextBox();
            Column1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            labelType = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(283, 69);
            label1.Name = "label1";
            label1.Size = new Size(189, 42);
            label1.TabIndex = 0;
            label1.Text = "Transaction";
            label1.Click += label1_Click;
            // 
            // moneyBox
            // 
            moneyBox.Font = new Font("Times New Roman", 23.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moneyBox.Location = new Point(295, 146);
            moneyBox.Name = "moneyBox";
            moneyBox.Size = new Size(177, 43);
            moneyBox.TabIndex = 1;
            moneyBox.TextAlign = HorizontalAlignment.Center;
            moneyBox.TextChanged += textBox1_TextChanged;
            // 
            // Column5
            // 
            Column5.Font = new Font("Times New Roman", 28F);
            Column5.Location = new Point(514, 224);
            Column5.MaxLength = 1;
            Column5.Name = "Column5";
            Column5.Size = new Size(50, 50);
            Column5.TabIndex = 19;
            Column5.TextAlign = HorizontalAlignment.Center;
            // 
            // Column4
            // 
            Column4.Font = new Font("Times New Roman", 28F);
            Column4.Location = new Point(449, 224);
            Column4.MaxLength = 1;
            Column4.Name = "Column4";
            Column4.Size = new Size(50, 50);
            Column4.TabIndex = 18;
            Column4.TextAlign = HorizontalAlignment.Center;
            // 
            // Column3
            // 
            Column3.Font = new Font("Times New Roman", 28F);
            Column3.Location = new Point(384, 224);
            Column3.MaxLength = 1;
            Column3.Name = "Column3";
            Column3.Size = new Size(50, 50);
            Column3.TabIndex = 17;
            Column3.TextAlign = HorizontalAlignment.Center;
            // 
            // Column2
            // 
            Column2.Font = new Font("Times New Roman", 28F);
            Column2.Location = new Point(314, 224);
            Column2.MaxLength = 1;
            Column2.Name = "Column2";
            Column2.Size = new Size(50, 50);
            Column2.TabIndex = 16;
            Column2.TextAlign = HorizontalAlignment.Center;
            // 
            // Column1
            // 
            Column1.Font = new Font("Times New Roman", 28F);
            Column1.Location = new Point(245, 224);
            Column1.MaxLength = 1;
            Column1.Name = "Column1";
            Column1.Size = new Size(50, 50);
            Column1.TabIndex = 15;
            Column1.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(169, 236);
            label2.Name = "label2";
            label2.Size = new Size(56, 31);
            label2.TabIndex = 14;
            label2.Text = "PIN";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14F);
            button1.Location = new Point(347, 317);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 20;
            button1.Text = "Verify";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelType.Location = new Point(12, 6);
            labelType.Name = "labelType";
            labelType.Size = new Size(29, 15);
            labelType.TabIndex = 21;
            labelType.Text = "Text";
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(labelType);
            Controls.Add(button1);
            Controls.Add(Column5);
            Controls.Add(Column4);
            Controls.Add(Column3);
            Controls.Add(Column2);
            Controls.Add(Column1);
            Controls.Add(label2);
            Controls.Add(moneyBox);
            Controls.Add(label1);
            Name = "Transaction";
            Text = "Transaction";
            Load += Transaction_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox moneyBox;
        public TextBox Column5;
        public TextBox Column4;
        public TextBox Column3;
        public TextBox Column2;
        public TextBox Column1;
        private Label label2;
        private Button button1;
        private Label labelType;
    }
}