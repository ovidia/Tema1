using System;
using System.Windows.Forms;
using BL;
using Entities;
using PiataAZ.UI;


namespace PiataAZ
{
    public partial class Form1 : Form
    {
        String username, pass;
       
        UserService userv = new UserService();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = textBox1.Text;
            pass = textBox2.Text;

            User u = userv.login(username, pass);

            if (u == null) MessageBox.Show("Nu exista  acest  utilizator!\nVa rugam sa creati un cont!");
            else if (u.getRolUser() == "admin")
            {
                var nf = new AdminForm();
                nf.Show();
            
            }
            else if (u.getRolUser() == "user")
            {
                var nf = new AnuntForm(username);
                nf.Show();
           
            }
           
            
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            var cont = new CreareCont();
            cont.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ForgetPassword n = new ForgetPassword();
            n.Show();
        }
    }
}
