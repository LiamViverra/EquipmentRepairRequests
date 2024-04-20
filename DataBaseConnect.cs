using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EquipmentRepairRequests
{
    public class DataBaseConnect
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LIAMPC\SQLEXPRESS;Initial Catalog=LiamDb6;Integrated Security=True");

        public void OpenConnectrion()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void CloseConnectrion()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
