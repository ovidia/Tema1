using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Entities;

namespace PiataAZ.UI
{
    public partial class Angajati : Form
    {
        UserService user = new UserService();
        DataTable dat = new DataTable();
        public Angajati()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dat = user.viewUsers();
            dataGridView1.DataSource = dat;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dat = user.viewRaport();
            dataGridView1.DataSource = dat;
        }
    }
}
