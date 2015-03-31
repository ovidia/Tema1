using System;

namespace Entities
{
   public  class User
   {
       public String nume, prenume, username, parola, rol;
       private int nranunturi;


        public User()
        {
            
        }

          public User(String n, String p,String u, String pa, String r, int cre)
        {
              nume = n;
              prenume = p;
              username = u;
              parola = pa;
              rol = r;
              nranunturi= cre;
        }

          public User(String n, String p, String u, String pa, String r)
          {
              nume = n;
              prenume = p;
              username = u;
              parola = pa;
              rol = r;
            
          }

         public  String getNumeUser()
          {
              return nume;
          }

         public  void setNumeUser(String n)
          {
              nume = n;
          }


          public String getPrenumeUser()
          {
              return prenume;
          }

          public void setPrenumeUser(String p)
          {
              prenume = p;
          }

       public   String getUsernameUser()
          {
              return username;
          }

        public  void setUsernameUser(String u)
          {
              username = u;
          }

        public   String getParolaUser()
          {
              return parola;
          }

         public void setParolaUser(String pa)
          {
              parola = pa;
          }


          public String getRolUser()
          {
              return rol;
          }

          public void setRolUser(String r)
          {
              rol = r;
          }

          public int getNrAnunturi()
          {
              return nranunturi;
          }

          public void setNrAnunturi(int c)
          {
             nranunturi = c;
          }

    }
}
