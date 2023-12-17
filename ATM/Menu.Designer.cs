namespace ATM
{
    partial class Menu
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
            withdrawBu = new Button();
            depositBu = new Button();
            transferBu = new Button();
            historyBu = new Button();
            Balance = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 97);
            label1.Name = "label1";
            label1.Size = new Size(128, 40);
            label1.TabIndex = 1;
            label1.Text = "Options";
            // 
            // withdrawBu
            // 
            withdrawBu.BackColor = SystemColors.ActiveCaption;
            withdrawBu.Font = new Font("Segoe UI", 13F);
            withdrawBu.Location = new Point(190, 179);
            withdrawBu.Name = "withdrawBu";
            withdrawBu.Size = new Size(134, 36);
            withdrawBu.TabIndex = 2;
            withdrawBu.Text = "Withdraw";
            withdrawBu.UseVisualStyleBackColor = false;
            withdrawBu.Click += button1_Click;
            // 
            // depositBu
            // 
            depositBu.BackColor = SystemColors.ActiveCaption;
            depositBu.Font = new Font("Segoe UI", 13F);
            depositBu.Location = new Point(441, 179);
            depositBu.Name = "depositBu";
            depositBu.Size = new Size(134, 36);
            depositBu.TabIndex = 3;
            depositBu.Text = "Deposit";
            depositBu.UseVisualStyleBackColor = false;
            depositBu.Click += button2_Click;
            // 
            // transferBu
            // 
            transferBu.BackColor = SystemColors.ActiveCaption;
            transferBu.Font = new Font("Segoe UI", 13F);
            transferBu.Location = new Point(190, 269);
            transferBu.Name = "transferBu";
            transferBu.Size = new Size(134, 36);
            transferBu.TabIndex = 4;
            transferBu.Text = "Transfer";
            transferBu.UseVisualStyleBackColor = false;
            // 
            // historyBu
            // 
            historyBu.BackColor = SystemColors.ActiveCaption;
            historyBu.Font = new Font("Segoe UI", 13F);
            historyBu.Location = new Point(441, 269);
            historyBu.Name = "historyBu";
            historyBu.Size = new Size(134, 36);
            historyBu.TabIndex = 5;
            historyBu.Text = "History";
            historyBu.UseVisualStyleBackColor = false;
            historyBu.Click += historyBu_Click;
            // 
            // Balance
            // 
            Balance.AutoSize = true;
            Balance.BackColor = SystemColors.ButtonFace;
            Balance.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Balance.Location = new Point(58, 60);
            Balance.Name = "Balance";
            Balance.Size = new Size(95, 36);
            Balance.TabIndex = 6;
            Balance.Text = "1000$";
            Balance.Click += Balance_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Balance);
            Controls.Add(historyBu);
            Controls.Add(transferBu);
            Controls.Add(depositBu);
            Controls.Add(withdrawBu);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Menu";
            Activated += Menu_Load;
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button withdrawBu;
        private Button depositBu;
        private Button transferBu;
        private Button historyBu;
        private Label Balance;
    }
}