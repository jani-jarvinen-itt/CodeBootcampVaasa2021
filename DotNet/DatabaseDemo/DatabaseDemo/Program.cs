using System;
using System.Data.SqlClient;

namespace DatabaseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting to access the SQL Server database.");
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;";
            SqlConnection connection = new(connectionString);
            connection.Open();
            Console.WriteLine("Connection to SQL Server is now open!");
        }
    }
}
