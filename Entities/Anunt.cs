using System;

namespace Entities
{
   public  class Anunt
    {
        String titlu, descriere, creatde;
        Byte imagine;
        public Anunt()
        {
        }

        public Anunt(String ti, String de, Byte img, String cre)
        {
            titlu = ti;
            descriere = de;
            imagine = img;
            creatde = cre;
        }

        public Anunt(String ti, String de)
        {
            titlu = ti;
            descriere = de;
         
        }
      String getTitluAnunt()
        {
            return titlu;
        }

        void setTitluAnunt(String t)
        {
            titlu = t;
        }

        String getDescriereAnunt()
        {
            return descriere;
        }

        void setDescriereAnunt(String d)
        {
            descriere = d;
        }

        public String getCreatDe()
        {
            return creatde;
        }

        public void setCreatDe(String c)
        {
            creatde = c;
        }
    }
}
