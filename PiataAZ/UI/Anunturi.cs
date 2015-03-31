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
    public partial class Anunturi : Form
    {
        AnuntService anunt = new AnuntService();
        DataTable dat = new DataTable();

        public Anunturi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dat = anunt.viewUsers();
            dataGridView1.DataSource = dat;
        }
    }
}
