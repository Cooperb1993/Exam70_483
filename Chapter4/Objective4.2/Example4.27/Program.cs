﻿using System.Data.SqlClient;

namespace Example4._27
{
    class Program
    {
        // This example is not supposed to work and would throw and exception as there are not such databases. The example simply shows a specific approach
        static void Main(string[] args)
        {
            string connectionString = @"Persist Security Info=False;Integrated Security=true;Initial Catalog=Northwind;server=(
local)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Execute operations agains the database
            } // Connection is automatically closed
        }
    }
}
