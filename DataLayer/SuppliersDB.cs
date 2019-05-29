using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BusinessLayer;

namespace DataLayer
{
   public class SuppliersDB
    {
        public static Suppliers GetSuppliersDB()
        {
            SqlConnection connection = TravelExperts.GetConnection();
            Suppliers S = new Suppliers();

            try

            {
                string sql = " Select * from Suppliers";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@SupplierId", S);
                command.Parameters.AddWithValue("@SupName", S);
                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                while (reader.Read())
                {

                    S.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                    S.SupName = Convert.ToString(reader["SupName"]);

                    // reader.Add(S);

                }

            }

            catch (Exception e)
            { }
            finally
            {
                connection.Close();
            }

            return S;

        }



    }
}
