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
            
            void listele()
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Select * from TblPerson", conn);
                //DataTable dt = new DataTable(); 
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + "  | " + reader[1] + " | " + reader[2]);
                    Console.WriteLine(".............................................");
                }


                conn.Close();
            }


            //--------Ekleme İşlemi-------------------

            //conn.Open();
            //    SqlCommand command2 = new SqlCommand("insert into TblPerson (Name,City) values (@p1,@p2)",conn);
            //command2.Parameters.AddWithValue("@p1", "Mesut Gedikli");
            //command2.Parameters.AddWithValue("@p2", "Samsun");
            //command2.ExecuteNonQuery();

            //conn.Close() ;  




            //--------Silme İşlemi-------------------
            //conn.Open();
            //SqlCommand command3 = new SqlCommand("delete from TblPerson where Id=@p1", conn);
            //command3.Parameters.AddWithValue("@p1", 3);
            //command3.ExecuteNonQuery();
            //conn.Close() ;  
            //listele();



            //--------Güncelleme İşlemi-------------------
            conn.Open();
            SqlCommand command4 = new SqlCommand("update TblPerson set Name=@p1,City=@p2 where Id=@p3", conn);
            command4.Parameters.AddWithValue("@p1", "Veli Yıldız");
            command4.Parameters.AddWithValue("@p2", "Bursa");
            command4.Parameters.AddWithValue("@p3", 1);
            command4.ExecuteNonQuery(); 
            conn.Close() ;  


            listele();
            Console.ReadLine();


        }
    }
}
//Data Source=IDEPEXSRV;Initial Catalog=DbVisit;Int"egrated Security=True