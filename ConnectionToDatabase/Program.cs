using System.Data.SqlClient;

namespace ConnectionToDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionStrings = @"Server=SADIG\SQLEXPRESS;Database=Ecommerce;Trusted_Connection=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStrings))
                {
                    connection.Open();
                    Console.WriteLine("Connection was established successfully");
                    Console.Write("Mehsulun adini daxil edin : ");
                    string name = Console.ReadLine();
                    Console.Write("Mehsulun qiymetini daxil edin : ");
                    decimal price = decimal.Parse(Console.ReadLine());
                    Console.Write("Mehsulun sayini daxil edin : ");
                    int count = int.Parse(Console.ReadLine());
                    Console.Write("Mehsulun kateqoriyani daxil edin : ");
                    int categoryId = int.Parse(Console.ReadLine());
                    InsertData(connection, name, price,count, categoryId);
                    GetDataFromCategories(connection);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void GetDataFromCategories(SqlConnection connection)
        {

            string commandStr = "select p.Id,p.Title,p.Price,c.[Name] as Category from Products as p " +
                        "join Categories as c " +
                        "on c.Id = p.CategoryId";
            SqlCommand cmd = new SqlCommand(commandStr, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    var value = reader.GetValue(i);
                    string columnName = reader.GetColumnSchema()[i].ColumnName;
                    Console.WriteLine($"{columnName} - {value}");
                }
                Console.WriteLine("\n ******* \n");
            }
        }

        static void InsertData(SqlConnection connection,string title,decimal price,int count,int categoryId)
        {
            string commandTxt = $"insert into Products(Title,Price,Count,CategoryId) values(@Title,@Price,@Count,@CategoryId)";
            using(SqlCommand command = new SqlCommand(commandTxt, connection))
            {
                command.Parameters.AddWithValue("@Title",title);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Count", count);
                command.Parameters.AddWithValue("@CategoryId", categoryId);
                try
                {
                    int result = command.ExecuteNonQuery();
                    Console.WriteLine($"{result} rows has been changed");
                    Console.WriteLine("Data added successfully");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}