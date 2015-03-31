using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;
using Entities;


namespace DAL
{
   public  class AnuntDAL
    {
        MySqlConnection conn;
        String connectionString;

       public AnuntDAL()
        {
            connectionString = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", "localhost", "root", "", "piataaz");
            conn = new MySqlConnection(connectionString);
        }


       public Anunt getAnunt(String titlu)
       {
           Anunt a = null;
           String sql = "SELECT * FROM anunt WHERE Titlu='" +titlu + "'";
           try
           {
               conn.Open();
               MySqlCommand cmd = new MySqlCommand(sql, conn);
               MySqlDataReader reader = cmd.ExecuteReader();
               reader.Read();

               if (reader.HasRows)
               {
                   a = new Anunt(reader["Titlu"].ToString(), reader["Descriere"].ToString());
                 //  byte[] imag = (byte[]) (reader["Imagine"]);
                  // if (imag == null) Image1.ImageUrl = null;
                //   else
                   //{
                       //MemoryStream mstream = new MemoryStream(imag);
                    //   Image1.ImageURL = "data:image/jpeg;base64," + Convert.ToBase64String(imag);
                   //}
               }
               else
               {
                  a = null;
               }
               conn.Close();

           }
           catch (MySqlException e)
           {
               Console.WriteLine(e.Message);
               conn.Close();
               return null;
           }
           return a;
       }


       public DataTable getAnunturi()
       {
           
           String sql = "SELECT * FROM anunt";
           DataTable data = new DataTable();

           try
           {
               conn.Open();
               MySqlCommand cmd = new MySqlCommand(sql, conn);
               MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);

               adapt.Fill(data);
             
               conn.Close();

           }
           catch (MySqlException e)
           {
               Console.WriteLine(e.Message);
               conn.Close();
               return null;
           }
           return data;
       }






       public Anunt createAnunt(String titlu, String descriere,Byte imagine, String creatde)
       {
           Anunt u = null;
           String sql = "INSERT INTO anunt (Titlu, Descriere, Imagine, CreatDe) VALUES ('" + titlu + "','" + descriere + "','" + imagine +"','"+creatde+"')";
           try
           {
               conn.Open();
               MySqlCommand cmd = new MySqlCommand(sql, conn);
               MySqlDataReader reader = cmd.ExecuteReader();
              conn.Close();
           }
           catch (MySqlException e)
           {
               Console.WriteLine(e.Message);
               conn.Close();
               return null;
           }
           return u;
       }



       public void stergeAnunt(String titlu)
       {

           String sql = "DELETE FROM anunt WHERE Titlu = '" + titlu + "'";
           try
           {
               conn.Open();
               MySqlCommand cmd = new MySqlCommand(sql, conn);
               MySqlDataReader reader = cmd.ExecuteReader();
               reader.Read();
               conn.Close();
           }
           catch (MySqlException e)
           {
               Console.WriteLine(e.Message);
               conn.Close();

           }

       }


       public void actualizareAnunt(String  titlu, String descriere,Byte imagine)
       {

           String sql = "UPDATE users SET Descriere='" + descriere + "', Imagine='"+imagine+"' WHERE Titlu='" + titlu+ "'";
           try
           {
               conn.Open();
               MySqlCommand cmd = new MySqlCommand(sql, conn);
               MySqlDataReader reader = cmd.ExecuteReader();
               reader.Read();
               conn.Close();
           }
           catch (MySqlException e)
           {
               Console.WriteLine(e.Message);
               conn.Close();

           }

       }



      












    }
}
