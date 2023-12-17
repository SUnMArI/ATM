using ATM.ConnectToDBMS;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Menu : Form
    {
        public static Menu Instance = new Menu();
        public string PIN = "s";
        public Menu()
        {
            InitializeComponent();
            Instance = this;
            this.PIN = Form1.Instance.PIN;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transaction.type = "Withdraw";
            new Transaction().ShowDialog();
            SqlServerConnectivity.Connection().Open();
            SqlServerConnectivity.Connection().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transaction.type = "Deposit";
            new Transaction().ShowDialog();
            SqlServerConnectivity.Connection().Open();
            SqlServerConnectivity.Connection().Close();
        }

        private void Balance_TextChanged(object sender, EventArgs e)
        {


        }

        private void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SqlServerConnectivity.Connection();
                conn.Open();
                string sql = $"SELECT * FROM users where pin='{PIN}'";
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Balance.Text = reader.GetInt32("amount").ToString() + "$";
                }

                conn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Balance_Click(object sender, EventArgs e)
        {

        }

        private void historyBu_Click(object sender, EventArgs e)
        {
            new History().ShowDialog();
        }
    }
}
