using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace ATM.ConnectToDBMS
{
    public class SqlServerConnectivity
    {
        public static SqlConnection Connection() 
        {
            SqlConnection conn;           
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "DESKTOP-4R8Q7V3";
                builder.InitialCatalog = "ATM_Server";
                builder.UserID = "sa";
                builder.Password = "123456";
                builder.TrustServerCertificate = true;
                conn = new SqlConnection(builder.ConnectionString);
                return conn;
        }
    }
}
