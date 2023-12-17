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
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && comboBox1.Text != "")
            {
                try
                {
                        SqlConnection conn = SqlServerConnectivity.Connection();
                        conn.Open();
                        string query = $"INSERT INTO users (firstname,lastname, gender, age , dob , pin ,status) " +
                            $" values (" +
                            $" '{textBox1.Text}' , '{textBox2.Text}' , '{comboBox1.Text}' , {textBox4.Text} , '{dateTimePicker1.Text}' ,  '{textBox3.Text}' , 'false')  ";
                        SqlCommand command = new SqlCommand(query,conn);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Recorded");
                        conn.Close();
                }catch(SqlException ex )
                {
                   MessageBox.Show(ex.Message);    
                }
              
            }
            else MessageBox.Show("Incorrect Data");
        }

        private void CreateAcc_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add("Female");
            list.Add("Male");
            comboBox1.DataSource = list;

              
        }
    }
}
