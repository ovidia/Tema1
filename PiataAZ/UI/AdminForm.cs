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
    public partial class AdminForm : Form
    {
        UserService user = new UserService();
        DataTable dat = new DataTable();

        public AdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AngajatForm nf = new AngajatForm();
            nf.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AngajatForm nf = new AngajatForm();
            nf.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AngajatForm nf = new AngajatForm();
            nf.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AngajatForm nf = new AngajatForm();
            nf.Show();
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Angajati nf = new Angajati();
            nf.Show();
            this.Visible = false;
        }


    }
}
