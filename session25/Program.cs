using System.Data;
using System.Data.SqlClient;
using System.Text;
// See https://aka.ms/new-console-template for more information

SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

builder.DataSource = @"localhost\SQLExpress";
builder.IntegratedSecurity = true;
builder.InitialCatalog = "Movies";

//String connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=Movies;Integrated Security=True";


using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
{
    Console.WriteLine("\nQuery data example:");
    Console.WriteLine("=========================================\n");

    connection.Open();

    String sql = "SELECT id, title, original_language FROM Movies2";

    using (SqlCommand command = new SqlCommand(sql, connection))
    {
        
        using (SqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                Console.WriteLine("{0} {1} {2}", 
                    reader.GetInt32(0), reader.GetString(1),
                    reader.GetString(2));
            }
        }
    }
}