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

namespace PiataAZ.UI
{
    public partial class AnuntForm : Form
    {

       public String titlu, descriere, username;
       public Byte imagine;
        public AnuntService anunt = new AnuntService();
        public UserService user = new UserService();
       int count = 0;

        public AnuntForm(String u)
        {
            InitializeComponent();
            username = u;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = user.getNumarAnunturi(username);
            n += 1;
            user.setNumarAnunturi(username, n);

            descriere = textBox1.Text;
            titlu = textBox2.Text;
            
            anunt.creatAnunt(titlu,descriere,imagine,username);
            MessageBox.Show("Anuntul a fost adaugat!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Anunturi na = new Anunturi();
            na.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cale = textBox3.Text;
           // label4 = cale;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = user.getNumarAnunturi(username);
            n -= 1;
            user.setNumarAnunturi(username, n);
            titlu = textBox2.Text;
            anunt.deleteAnunt(titlu);
            MessageBox.Show("Anuntul a fost sters!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            descriere = textBox1.Text;
            titlu = textBox2.Text;
            anunt.updateAnunt(titlu, descriere,imagine);
            MessageBox.Show("Anuntul a fost actualizat!");
        }

        private void AnuntForm_Load(object sender, EventArgs e)
        {

        }

       
    }
}
