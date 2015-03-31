using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Entities;

namespace PiataAZ.UI
{
    public partial class AngajatForm : Form
    {

        public String nume, prenume, username, parola, rol,s;
        UserService user = new UserService();

        public AngajatForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            nume = textBox1.Text;
            prenume = textBox2.Text;
            username = textBox5.Text;
            parola = textBox6.Text;
            s =user. getMd5Hash(parola);
            user.createUser(nume, prenume,username, s, "user", 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nume = textBox1.Text;
            user.deleteUser(nume);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nume = textBox1.Text;
            username = textBox5.Text;
            parola = textBox6.Text;
            s = user.getMd5Hash(parola);
            user.updateUser(nume,username,s,"user");
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Angajati a = new Angajati();
            a.Show();
            
        }
    }
}
