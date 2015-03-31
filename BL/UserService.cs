using System;
using System.Data;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using DAL;
using Entities;


namespace BL
{
    public class UserService
    {

        public UserService()
        {
            
        }

        UserDAL us = new UserDAL();
        User user  = new User();
        DataTable allu = new DataTable();

       
        public User login(String username, String pass)
        {
            String s = getMd5Hash(pass);
            User u1 = us.getUser(username, s);

            return u1;
        }




        public  void createUser(String nume, String prenume, String username, String password, String rol, int nranunturi)
        {
            us.creareUser(nume, prenume, username, password, rol,nranunturi);
        }


       public  void deleteUser(String nume)
        {
            us.stergeUser(nume);
        }


        public void updateUser(String nume,  String username, String password, String rol)
        {
            us.actualizareUser(nume,username,password, rol);
        }



        public User viewUser(String username, String password)
        {
            user =  us.getUser(username, password);
            return user;
        }


        public DataTable viewUsers()
        {
            allu =   us.getAllUsers();
            return allu;
        }

        public DataTable viewRaport()
        {
            allu = us.getRaport();
            return allu;
        }

        public int getNumarAnunturi(String uname)
        {
            return us.selectNrAnunturi(uname);
        }

        public void setNumarAnunturi(String uname, int nr)
        {
          us.actualizareNrAnunturi(uname, nr);
        }


        public void updatePass(String username, String pass)
        {
            String s =getMd5Hash(pass);
            us.actualizareParola(username,s);
        }


        public String getRandomPass()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

                var finalString = new String(stringChars);
            return finalString;
        }
       
    

        public string getMd5Hash(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }









    }
}
