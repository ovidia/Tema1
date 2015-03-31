using System;
using System.Data;
using MySql.Data.MySqlClient;
using Entities;


namespace DAL
{
    public class UserDAL
    {
        MySqlConnection conn;
        String connectionString;

        public UserDAL()
        {
            connectionString = String.Format("server={0};user id={1}; password={2}; database={3}; pooling=false", "localhost", "root", "", "piataaz");
            conn = new MySqlConnection(connectionString);
        }

      

        

       public User getUser(String username, String password)
        {
            User u = null;
            String sql = "SELECT * FROM users WHERE Username='" + username + "' AND Parola='" + password + "'";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    u = new User(reader["Nume"].ToString(), reader["Prenume"].ToString(), reader["Username"].ToString(),reader["Parola"].ToString() ,reader["Rol"].ToString());
                }
                else
                {
                    u = null;
                }
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


        public DataTable getAllUsers()
        {

            String sql = "SELECT * FROM users";
           
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

        public DataTable getRaport()
        {

            String sql = "SELECT Nume,Prenume,NumarAnunturi FROM users";

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





        public void creareUser(String nume, String prenume, String uname, String parola, String rol,int nranunturi)
            {
                String sql = "INSERT INTO users (Nume, Prenume, Username,Parola, Rol,NumarAnunturi) VALUES ('" + nume + "','" + prenume + "','" + uname + "','" + parola + "','"+rol+"','"+nranunturi+"')";
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
               
            }
            }


        public void stergeUser(String nume)
        {
           
            String sql = "DELETE FROM users WHERE Nume = '"+nume+"';";
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
             
            }
          
        }


        public void actualizareUser(String nume,  String uname, String parola, String rol)
        {

            String sql = "UPDATE users SET Username='" + uname + "' , Parola='" + parola + "' , Rol='" + rol + "' WHERE Nume='" + nume + "'";
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

            }

        }


        public void actualizareNrAnunturi( String uname, int nr)
        {

            String sql = "UPDATE users SET NumarAnunturi='" + nr +  "' WHERE Username='" + uname + "'";
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

            }

        }


        public int selectNrAnunturi(String uname)
        {
            int i = -1;
            String sql = "SELECT NumarAnunturi FROM users  WHERE Username='" + uname + "'";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
              //  MySqlDataReader reader = cmd.ExecuteReader();

                i = (Int32)cmd.ExecuteScalar();

             
                conn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                conn.Close();

            }
            return i;

        }



        public void actualizareParola(String nume,String parola)
        {

            String sql = "UPDATE users SET Parola='" + parola +  "' WHERE Username='" + nume + "'";
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

            }

        }





    }
}
