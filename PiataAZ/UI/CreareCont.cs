using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace PiataAZ.UI
{
    public partial class CreareCont : Form
    {
        UserService userv = new UserService();
        private String nume, prenume, username, parola,s;

        public CreareCont()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nume = textBox1.Text;
            prenume = textBox2.Text;
            username = textBox3.Text;
            parola = textBox4.Text;
            s = userv.getMd5Hash(parola);
            userv.createUser(nume, prenume, username, s, "user",0);
            MessageBox.Show("Contul dumneavoastra a fost creat!\nVa puteti autentifica.");
            this.Visible = false;
           
        }
    }
}
