using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbbCon
{
    class datacon
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Bookdat_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            try
            {
                connection.Open();
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand("select * from BookUser", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(string.Format("{0} {1}", reader["UserId"].ToString(), reader["FirstName"].ToString()));

                }
                reader.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                connection.Close();

            }
            Console.ReadKey();

        }

    }

}