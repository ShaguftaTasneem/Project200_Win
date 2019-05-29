using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataLayer
{
    class TravelExperts
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection();
            string ConnectionString = "Data Source=SOFTDEV\\SQLEXPRESS;Initial Catalog=TravelExpert;Integrated Security=true;";
            connection.ConnectionString = ConnectionString;
            connection.Open();
            return connection;

        }
    }
}
