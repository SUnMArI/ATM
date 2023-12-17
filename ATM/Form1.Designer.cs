namespace ATM
{
    partial class Form1
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
            label1 = new Label();
            create_bt = new Button();
            enter_bt = new Button();
            label4 = new Label();
            label2 = new Label();
            Column1 = new TextBox();
            Column2 = new TextBox();
            Column3 = new TextBox();
            Column4 = new TextBox();
            Column5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 58);
            label1.Name = "label1";
            label1.Size = new Size(115, 31);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // create_bt
            // 
            create_bt.Font = new Font("Segoe UI", 10F);
            create_bt.Location = new Point(336, 349);
            create_bt.Name = "create_bt";
            create_bt.Size = new Size(75, 28);
            create_bt.TabIndex = 3;
            create_bt.Text = "Create";
            create_bt.UseVisualStyleBackColor = true;
            create_bt.Click += create_bt_Click;
            // 
            // enter_bt
            // 
            enter_bt.Font = new Font("Segoe UI", 10F);
            enter_bt.Location = new Point(336, 264);
            enter_bt.Name = "enter_bt";
            enter_bt.Size = new Size(75, 28);
            enter_bt.TabIndex = 6;
            enter_bt.Text = "Enter";
            enter_bt.UseVisualStyleBackColor = true;
            enter_bt.Click += enter_bt_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(247, 314);
            label4.Name = "label4";
            label4.Size = new Size(274, 19);
            label4.TabIndex = 7;
            label4.Text = "Click Create Button To Create New Account";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(149, 178);
            label2.Name = "label2";
            label2.Size = new Size(56, 31);
            label2.TabIndex = 8;
            label2.Text = "PIN";
            // 
            // Column1
            // 
            Column1.Font = new Font("Times New Roman", 28F);
            Column1.Location = new Point(225, 166);
            Column1.MaxLength = 1;
            Column1.Name = "Column1";
            Column1.Size = new Size(50, 50);
            Column1.TabIndex = 9;
            Column1.TextAlign = HorizontalAlignment.Center;
            // 
            // Column2
            // 
            Column2.Font = new Font("Times New Roman", 28F);
            Column2.Location = new Point(294, 166);
            Column2.MaxLength = 1;
            Column2.Name = "Column2";
            Column2.Size = new Size(50, 50);
            Column2.TabIndex = 10;
            Column2.TextAlign = HorizontalAlignment.Center;
            // 
            // Column3
            // 
            Column3.Font = new Font("Times New Roman", 28F);
            Column3.Location = new Point(364, 166);
            Column3.MaxLength = 1;
            Column3.Name = "Column3";
            Column3.Size = new Size(50, 50);
            Column3.TabIndex = 11;
            Column3.TextAlign = HorizontalAlignment.Center;
            // 
            // Column4
            // 
            Column4.Font = new Font("Times New Roman", 28F);
            Column4.Location = new Point(429, 166);
            Column4.MaxLength = 1;
            Column4.Name = "Column4";
            Column4.Size = new Size(50, 50);
            Column4.TabIndex = 12;
            Column4.TextAlign = HorizontalAlignment.Center;
            // 
            // Column5
            // 
            Column5.Font = new Font("Times New Roman", 28F);
            Column5.Location = new Point(494, 166);
            Column5.MaxLength = 1;
            Column5.Name = "Column5";
            Column5.Size = new Size(50, 50);
            Column5.TabIndex = 13;
            Column5.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Column5);
            Controls.Add(Column4);
            Controls.Add(Column3);
            Controls.Add(Column2);
            Controls.Add(Column1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(enter_bt);
            Controls.Add(create_bt);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button create_bt;
        private Button enter_bt;
        private Label label4;
        private Label label2;
        public TextBox Column1;
        public TextBox Column2;
        public TextBox Column3;
        public TextBox Column4;
        public TextBox Column5;
    }
}
