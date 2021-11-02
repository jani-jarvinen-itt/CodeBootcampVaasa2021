using System;
using System.Data.SqlClient;

namespace DatabaseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // open connection to the database
            Console.WriteLine("Starting to access the SQL Server database.");
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;";
            SqlConnection connection = new(connectionString);
            connection.Open();
            Console.WriteLine("Connection to SQL Server is now open!");

            // execute the SQL query
            string sql = "SELECT * FROM Customers WHERE Country = 'Finland'";
            SqlCommand command = new(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            // process the results
            while (reader.Read())
            {
                string name = reader["CompanyName"].ToString();
                Console.WriteLine(name);
            }
        }
    }
}
