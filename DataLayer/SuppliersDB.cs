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

        public static List<Suppliers> GetSuppliersGridDB()  // Prepares the dta for Grid View

        {
            SqlConnection connection = TravelExperts.GetConnection();
            Suppliers S;
            List<Suppliers> lstSuppliers = new List<Suppliers>();
            try

            {
                string sql = " Select * from Suppliers";

                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    S = new Suppliers();

                    S.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                    S.SupName = Convert.ToString(reader["SupName"]);

                    // reader.Add(O);

                    lstSuppliers.Add(S);
                }

            }

            catch (Exception e)
            { }
            finally
            {
                connection.Close();
            }

            return lstSuppliers;

        }

        public static int UpdateSupplier(string SupName)  // Update the data in ShippedDate field
        {
            SqlConnection connection = TravelExperts.GetConnection();
            int ireturn = 0;
            {
                try

                {
                    string sql = " UPDATE Suppliers SET SupplierId =@SupplierId , SupName=@SupName";
                    //where OrderID='OrderID'";
                    //"WHERE RequiredDate > ShippedDate AND ShippedDate < OrderDate";
                    SqlCommand command = new SqlCommand(sql, connection);

                    //command.Parameters.AddWithValue("@SupplierId",SupplierId);
                    command.Parameters.AddWithValue("@SupName", SupName);


                    ireturn = command.ExecuteNonQuery();
                }

                catch (Exception e)
                { }

                finally
                {
                    connection.Close();
                }

            }
            return ireturn;
        }



    }
}
