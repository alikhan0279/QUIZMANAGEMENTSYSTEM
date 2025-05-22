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
    public partial class Studentdetails : Form
    {
        public Studentdetails()
        {
            InitializeComponent();
        }

        private void Studentdetails_Load(object sender, EventArgs e)
        {
            QController q = new QController();
           
            dataGridView1.DataSource = q.ViewSinfo().Tables[0];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            int rollno = int.Parse(txtrollno.Text);
            QController q = new QController();
            a = q.DeleteS(rollno);
            if (a > 0)
            {
                MessageBox.Show("Student deleted", "Success");
            }
            else
            {
                MessageBox.Show("Some problem occured while deleting student", "Error");
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
