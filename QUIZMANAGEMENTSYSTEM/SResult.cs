using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUIZMANAGEMENTSYSTEM
{
    public partial class SResult : Form
    {
        public SResult()
        {
            InitializeComponent();
        }

        private void SResult_Load(object sender, EventArgs e)
        {

            QController q = new QController();
            dataGridView1.DataSource = q.ShowSResult().Tables[0];
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
