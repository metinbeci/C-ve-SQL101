using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Console_Application.Model;
namespace Console_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SqlConnection conn = new SqlConnection("Data Source=IDEPEXSRV;Initial Catalog=DbVisit;Integrated Security=True");
            
            //void listele()
            //{
            //    conn.Open();
            //    SqlCommand command = new SqlCommand("Select * from TblPerson", conn);
            //    //DataTable dt = new DataTable(); 
            //    SqlDataReader reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        Console.WriteLine(reader[0] + "  | " + reader[1] + " | " + reader[2]);
            //        Console.WriteLine(".............................................");
            //    }


            //    conn.Close();
            //}


            //***************Entity Framework Listeleme*****************

            /*
                adonet vs entity Framework
                code first vs dbfirst
                asp.net core
                dbfirst
             */

            DbVisitEntities db =new DbVisitEntities();
            void listele()
            {
                var values = db.TblCountry.ToList();
                //Console.WriteLine(values);
                foreach (var item in values)
                {
                    Console.WriteLine(item.CountryId + "-" + item.CountryName + "-" + item.CountryCapital);
                    Console.WriteLine("**************************");
                }
            }

            //***************Entity Framework Ekleme*****************
            //--sınıf--prop--value
            //TblPerson t =new TblPerson();


            //t.City = "İzmir";
            //t.Name = "Berat Yıldırım";
            //db.TblPerson.Add(t);
            //db.SaveChanges();   
            //listele();  




            //***************Entity Framework Silme**********************

            //Console.Write("Sillinecek Değeri Girin:");
            //int countryCode = Convert.ToInt32(Console.ReadLine());

            //var value = db.TblCountry.Find(2);
            //db.TblCountry.Remove(value);
            //db.SaveChanges();
            //listele();


            //***************Entity Framework Güncelleme*****************

            //TblCountry t = new TblCountry();
            //var value = db.TblCountry.Find(1);
            //value.CountryName = "Almanya";
            //value.CountryCapital = "Berlin";
            //db.SaveChanges();
            //listele();  

            //***************Entity Framework Arama***********************
            //Console.Write("Ülke Adı Giriniz: ");
            //string country =Console.ReadLine();
            //var values2 = db.TblCountry.Where(x => x.CountryName == country).ToList();
            //foreach (var item in values2)
            //{
            //    Console.WriteLine(item.CountryId + " " + item.CountryCapital);
            //}

            //Şartlı sorgulama birden fazla 
            //var values3=db.TblFlight.Where(x=>x.DepartureLocation==1 && x.Price<=900).ToList();
            //foreach(var item in values3)
            //{
            //    Console.WriteLine("ID:" + item.FlightID + " Nereden: "+item.TblCountry.CountryCapital+" Fiyat: " + item.Price);
            //}



            Console.ReadLine();




        }
    }
}
