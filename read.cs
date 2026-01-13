using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string cs = @"Data Source=LAPTOP-3OQHG7D2\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True;TrustServerCertificate=True";

        SqlConnection con = new SqlConnection(cs);

        string query = "SELECT * FROM Student";
        SqlCommand cmd = new SqlCommand(query, con);

        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            Console.WriteLine(dr["Id"] + " " + dr["Name"] + " " + dr["Age"]);
        }

        con.Close();
    }
}
