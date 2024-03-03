using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace ConsoleAppAdoNetIntro
{
    internal class Program
    {
        const string cString = "Data Source=.;Database=ShopDb;User Id=adonet;Password=query;Encrypt=false";
        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        private static void WorkingWithExecuteReaderCallStoredProsecure()
        {
            Console.Write("a: ");
            string v1 = Console.ReadLine();
            Console.Write("b: ");
            string v2 = Console.ReadLine();
            //Extra Large - Edited from App
            // Sql Injection
            using (var connection = new SqlConnection(cString))
            //raw sql
            using (var command = new SqlCommand(@"[dbo].[spTopla2]", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@a", v1);
                command.Parameters.AddWithValue("@b", v2);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        Console.Write($"{reader["Cavab"]}  ");
                        Console.WriteLine($"{reader["ExecutingTime"]}  ");
                    }
                }
            }
        }

        private static void WorkingWithExecuteScalar()
        {
            //Extra Large - Edited from App
            // Sql Injection
            using (var connection = new SqlConnection(cString))
            //raw sql
            using (var command = new SqlCommand(@"select count(Id) from dbo.sizes", connection))
            {
                connection.Open();

                object value = command.ExecuteScalar();

                Console.WriteLine(value);
            }
        }

        private static void WorkingWithExecuteReaderInsertAndSelect()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("SmallName: ");
            string smallName = Console.ReadLine();

            //Extra Large - Edited from App
            // Sql Injection
            using (var connection = new SqlConnection(cString))
            //raw sql
            using (var command = new SqlCommand(@"insert into [dbo].[Sizes]([Name],[SmallName],[CreatedAt],[CreatedBy])
                                                  values(@name,@smallName,getutcdate(),1);
                                                  select [Id],[Name],[SmallName],[CreatedAt],[LastModifiedAt] from [dbo].[Sizes] where Id = SCOPE_IDENTITY()", connection))
            {
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@smallName", smallName);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        Console.Write($"{reader["Id"]}  ");
                        Console.Write($"{reader["Name"]}  ");
                        Console.Write($"{reader["SmallName"]}  ");
                        Console.Write($"{reader["CreatedAt"]}  ");
                        Console.WriteLine($"... {reader["LastModifiedAt"]} ...");
                    }
                }
            }
        }

        private static void WorkingWithExecuteNonQueryDelete()
        {
            Console.Write("Id: ");
            string id = Console.ReadLine();

            //Extra Large - Edited from App
            // Sql Injection
            using (var connection = new SqlConnection(cString))
            //raw sql
            using (var command = new SqlCommand(@"delete from [dbo].[Sizes] where Id = @id", connection))
            {
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
            Console.ReadKey();
        }

        private static void WorkingWithExecuteNonQueryInsert()
        {
            Console.Write("Teze Ad: ");
            string name = Console.ReadLine();
            Console.Write("Qisa ad: ");
            string smallName = Console.ReadLine();

            //Extra Large - Edited from App
            // Sql Injection
            using (var connection = new SqlConnection(cString))
            //raw sql
            using (var command = new SqlCommand(@"insert into [dbo].[Sizes]([Name],[SmallName],[CreatedAt],[CreatedBy])
                                                  values(@name,@smallName,getutcdate(),1)", connection))
            {
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@smallName", smallName);
                connection.Open();
                command.ExecuteNonQuery();
            }
            Console.ReadKey();
        }

        private static void WorkingWithExecuteNonQueryUpdate()
        {
            Console.Write("Teze Ad: ");
            string name = Console.ReadLine();
            Console.Write("Id: ");
            string id = Console.ReadLine();

            //Extra Large - Edited from App
            // Sql Injection
            using (var connection = new SqlConnection(cString))
            //raw sql
            using (var command = new SqlCommand(@"update [dbo].[Sizes] set [Name]=@name where Id = @id", connection))
            {
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                command.ExecuteNonQuery();
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
