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
    public partial class TResult : Form
    {
        public TResult()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TResult_Load(object sender, EventArgs e)
        {
            QController q = new QController();
            dataGridView1.DataSource = q.ShowTResult().Tables[0];


        }
    }
}
