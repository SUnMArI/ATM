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
            label2 = new Label();
            label3 = new Label();
            create_bt = new Button();
            user_textBox = new TextBox();
            code_textBox = new TextBox();
            enter_bt = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(336, 37);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(262, 166);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 1;
            label2.Text = "Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(262, 124);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 2;
            label3.Text = "Username";
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
            // user_textBox
            // 
            user_textBox.Location = new Point(390, 126);
            user_textBox.Name = "user_textBox";
            user_textBox.Size = new Size(100, 23);
            user_textBox.TabIndex = 4;
            // 
            // code_textBox
            // 
            code_textBox.Location = new Point(390, 168);
            code_textBox.Name = "code_textBox";
            code_textBox.Size = new Size(100, 23);
            code_textBox.TabIndex = 5;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(enter_bt);
            Controls.Add(code_textBox);
            Controls.Add(user_textBox);
            Controls.Add(create_bt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button create_bt;
        private TextBox user_textBox;
        private TextBox code_textBox;
        private Button enter_bt;
        private Label label4;
    }
}
