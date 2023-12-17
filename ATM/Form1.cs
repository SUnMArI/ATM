using ATM.ConnectToDBMS;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ATM
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public string PIN;
        public Form1()
        {
            InitializeComponent();
            Instance = this;
            this.PIN = Column1.Text + Column2.Text + Column3.Text + Column4.Text + Column5.Text;

        }

        private void create_bt_Click(object sender, EventArgs e)
        {

            if (OnClick != null)
            {
                new CreateAcc().ShowDialog();
                //new Form1().Close();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void enter_bt_Click(object sender, EventArgs e)
        {
            // Combination text of each Columuns
             this.PIN = Column1.Text + Column2.Text + Column3.Text + Column4.Text + Column5.Text;
            Boolean check = true;
            try
            {
                SqlConnection conn = SqlServerConnectivity.Connection();
                string sql = "SELECT pin FROM users ";
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                
                while (reader.Read())
                {
                    if (reader.GetString("pin").CompareTo(PIN) == 0)
                    {
                        History.PIN=PIN;
                        Menu.Instance.PIN = PIN;
                        Transaction.PIN = PIN;
                        conn.Close();
                        check = false;
                        new Menu().ShowDialog(); break;
                    }
                  

                }

                if (check) { MessageBox.Show("PIN INCORRECT"); }

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
