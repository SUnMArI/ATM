using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ATM.ConnectToDBMS
{
    internal class SqlServerConnectivity
    {
        public static void Connection()
        {
            SqlConnection conn;
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "DESKTOP-4R8Q7V3";
                builder.InitialCatalog = "ATM_Server";
                builder.TrustServerCertificate = true;
                conn = new SqlConnection(builder.ConnectionString);
              
            }
            catch (SqlException ex)
            {   
                MessageBox.Show(ex.Message);

            }

           
        }
    }
}
