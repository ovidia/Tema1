using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BL
{
    public class AnuntService
    {
        DataTable allanun = new DataTable();
        AnuntDAL an = new AnuntDAL();
         Anunt a = new Anunt();


        public AnuntService()
        {
            
        }


        public void creatAnunt(String titlu, String descriere, Byte imagine, String creatde)
        {
            
            an.createAnunt(titlu, descriere,imagine,creatde);
        }


        public void deleteAnunt(String nume)
        {
            an.stergeAnunt(nume);
        }


        public void updateAnunt(String titlu, String descriere, Byte imagine)
        {
           an.actualizareAnunt(titlu,descriere,imagine);
        }



        public Anunt viweAnunt(String titlu)
        {
            a = an.getAnunt(titlu);
            return a;
        }


        public DataTable viewUsers()
        {
            allanun = an.getAnunturi();
            return allanun;
        }






    }
}
