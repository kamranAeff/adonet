using System.Data;
using System.Data.SqlClient;

namespace ConsoleAppAdoNetIntro
{
    internal class Program
    {
        const string cString = "Data Source=.;Database=ShopDb;Trusted_Connection=True;Encrypt=false";
        static void Main(string[] args)
        {
            using (var connection = new SqlConnection(cString))
            using (var command = new SqlCommand("select [Id],[Name],[SmallName] from [dbo].[Sizes]", connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        Console.Write($"{reader["Id"]}  ");
                        Console.Write($"{reader["Name"]}  ");
                        Console.WriteLine($"{reader["SmallName"]}");
                    }
                }
            }
            Console.ReadKey();
        }

        private static void WorkingWithSqlDataReader()
        {
            using (var connection = new SqlConnection(cString))
            using (var command = new SqlCommand("select [Id],[Name],[SmallName] from [dbo].[Sizes]", connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        Console.Write($"{reader["Id"]}  ");
                        Console.Write($"{reader["Name"]}  ");
                        Console.WriteLine($"{reader["SmallName"]}");
                    }
                }
            }
            Console.ReadKey();
        }

        private static void WorkingSqlDataAdapter()
        {
            var connection = new SqlConnection(cString);

            var adapter = new SqlDataAdapter("select [Id],[Name],[SmallName] from [dbo].[Sizes]", connection);

            var table = new DataTable();

            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                Console.Write($"{row["Id"]}  ");
                Console.Write($"{row["Name"]}  ");
                Console.WriteLine($"{row["SmallName"]}");
            }

            Console.ReadKey();
        }
    }
}
