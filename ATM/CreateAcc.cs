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
    public partial class CreateAcc : Form
    {
        public CreateAcc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void verify_bt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                SqlServerConnectivity.Connection();
                string query = $"INSERT INTO Users (First_Name,Last_Name,Username,Password) " +
                    $" values (" +
             /* Firstname */        $" '{textBox1.Text}'," +
             /* Lastname */         $" '{textBox2.Text}'," +
             /* Username */         $" '{textBox3.Text}'," +
             /* Password */         $" '{textBox4.Text}') ";
                SqlCommand command = new SqlCommand(query);
                command.ExecuteNonQuery();
                MessageBox.Show("Corrected");
                //SqlServerConnectivity.Connection().Close();
            }
            else MessageBox.Show("Incorrect Data");
        }
    }
}
