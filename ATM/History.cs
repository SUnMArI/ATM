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
    public partial class History : Form
    {
        public static string PIN;
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Transaction", typeof(string));
            dataTable.Columns.Add("Amount", typeof(int));
            dataTable.Columns.Add("Date", typeof(DateTime));
            int usersID=0;
            try
            {
                SqlConnection conn = SqlServerConnectivity.Connection();
                conn.Open();
                string sql1 = $"SELECT users_id FROM users WHERE pin ={PIN}";
                SqlCommand cm = new SqlCommand(sql1, conn);
                SqlDataReader rdr = cm.ExecuteReader();
                while (rdr.Read())
                {
                    usersID = rdr.GetInt32("users_id");
                }
                conn.Close();
                string sql = $"SELECT * FROM transactiontb WHERE users_id = {usersID}";
                SqlCommand cmd = new SqlCommand(sql,conn);
                conn.Open() ;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dataTable.Rows.Add(reader.GetString("transaction_type"),reader.GetInt32("amount"), reader.GetDateTime("dob") );
                }
                conn.Close();
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


            dataGridView1.DataSource = dataTable;
        }
    }
}
