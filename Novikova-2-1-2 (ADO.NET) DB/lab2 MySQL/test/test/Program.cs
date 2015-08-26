using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            string connectionString = "Data Source=Artemis\\SQLEXPRESS;Initial Catalog=Salon Krasi;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                //
                // Open the SqlConnection.
                //
                con.Open();
                //
                // The following code uses an SqlCommand based on the SqlConnection.
                //
                using (SqlCommand command = new SqlCommand("SELECT TOP 2 * FROM [Fahivtsi Salonu]", con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        Console.WriteLine("{0} {1} {2}",
                        reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                    }
                }
            }
        }

    }
}

