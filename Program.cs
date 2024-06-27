using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=IDEPEXSRV;Initial Catalog=DbVisit;Integrated Security=True");
            conn.Open();
            SqlCommand command= new SqlCommand("Select * from TblPerson",conn);
            //DataTable dt = new DataTable(); 
            SqlDataReader reader = command.ExecuteReader(); 
            while (reader.Read())
            {
                Console.WriteLine(reader[0] + "  | " + reader[1] + " | " + reader[2]);
                Console.WriteLine("...........................................");
            }


            conn.Close();   


            Console.ReadLine();


        }
    }
}
//Data Source=IDEPEXSRV;Initial Catalog=DbVisit;Integrated Security=True