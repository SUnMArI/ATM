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
    public partial class Transaction : Form
    {
        public static string PIN;
        public static string type;
        public Transaction()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            labelType.Text = type;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (type == "Withdraw")
            {
                string check = Column1.Text + Column2.Text + Column3.Text + Column4.Text + Column5.Text;
                if (check.CompareTo(PIN) == 0)
                {
                    int money = Int32.Parse(moneyBox.Text);
                    int amount = 0;
                    int users_id = 0;
                    try
                    {
                        SqlConnection conn = SqlServerConnectivity.Connection();
                        conn.Open();
                        string sql = $"SELECT * FROM users where pin='{PIN}'";
                        SqlCommand sqlCommand = new SqlCommand(sql, conn);
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            amount = reader.GetInt32("amount");
                            users_id = reader.GetInt32("users_id");
                        }
                        conn.Close();


                        if (money > amount)
                        {
                            MessageBox.Show("You don't have enough money ");
                        }
                        else
                        {

                            string sql1 = $"INSERT INTO transactiontb (users_id,transaction_type,amount ,dob) values ({users_id},'{type}',{money},'{DateTime.Now.Date.ToString("yyyy-MM-dd HH:mm:ss.fff")}')";
                            SqlCommand cmd = new SqlCommand(sql1, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();

                            conn.Close();

                            string sql2 = $"UPDATE users SET amount={amount - money} WHERE pin ={PIN}";
                            SqlCommand cmd1 = new SqlCommand(sql2, conn);
                            conn.Open();
                            cmd1.ExecuteNonQuery();
                            conn.Close();
                            moneyBox.Text = "";
                            Column1.Text = "";
                            Column2.Text = "";
                            Column3.Text = "";
                            Column4.Text = "";
                            Column5.Text = "";

                        }
                        MessageBox.Show("Success");

                        Menu.Instance.Refresh();
                    }
                    catch (SqlException ex)
                    {
                        
                        MessageBox.Show(ex.Message);
                    }
                }
                else MessageBox.Show("Wrong PIN");
            }
            else
            {
               
                string check = Column1.Text + Column2.Text + Column3.Text + Column4.Text + Column5.Text;
                if (check.CompareTo(PIN) == 0)
                {
                    int money = Int32.Parse(moneyBox.Text);
                    int amount = 0;
                    int users_id = 0;
                    try
                    {
                        SqlConnection conn = SqlServerConnectivity.Connection();
                        conn.Open();
                        string sql = $"SELECT * FROM users where pin='{PIN}'";
                        SqlCommand sqlCommand = new SqlCommand(sql, conn);
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            amount = reader.GetInt32("amount");
                            users_id = reader.GetInt32("users_id");
                        }
                        conn.Close();
                            string sql1 = $"INSERT INTO transactiontb (users_id,transaction_type,amount ,dob) values ({users_id},'{type}',{money},'{DateTime.Now.Date.ToString("yyyy-MM-dd HH:mm:ss.fff")}')";
                            SqlCommand cmd = new SqlCommand(sql1, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();

                            conn.Close();

                            string sql2 = $"UPDATE users SET amount={amount + money} WHERE pin ={PIN}";
                            SqlCommand cmd1 = new SqlCommand(sql2, conn);
                            conn.Open();
                            cmd1.ExecuteNonQuery();
                            conn.Close();
                        moneyBox.Text = "";
                        Column1.Text = "";
                        Column2.Text = "";
                        Column3.Text = "";
                        Column4.Text = "";
                        Column5.Text = "";
                        MessageBox.Show("Success");
                        Menu.Instance.Refresh();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else MessageBox.Show("Wrong PIN");
            }
       
            
            

           
        }
    }
}
