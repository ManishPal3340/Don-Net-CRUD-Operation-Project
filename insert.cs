using System;
using Microsoft.Data.SqlClient; // Ya System.Data.SqlClient

class Program
{
    static void Main()
    {
        // 1. Connection string mein apna sahi server aur DB name dalein
        string cs = @"Data Source=LAPTOP-3OQHG7D2\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True;TrustServerCertificate=True";

        try
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                // Query mein table name check karlein (Student hai ya kuch aur)
                string query = "INSERT INTO Student (Id, Name, Age) VALUES (1, 'Manish', 22)";

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                Console.WriteLine("Data Inserted Successfully!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Kuch error aaya hai: " + ex.Message);
        }
    }
}