using System;
using System.Windows.Forms;
using BL;

namespace PiataAZ.UI
{
    public partial class ForgetPassword : Form
    {
        public String a, b;
        UserService user = new UserService();

        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = textBox1.Text;
            b =  user.getRandomPass();
            textBox2.Text = b;
            user.updatePass(a,b);
        }

    }
}
