using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CRUDDapper.Models
{
    internal class AppConnection
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

        public static SqlConnection Connection
        {
            get
            {
                var connection = new SqlConnection(ConnectionString);

                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to connect to database! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw new Exception("Failed to connect to database.", ex);
                }

                return connection;
            }
        }
    }
}
