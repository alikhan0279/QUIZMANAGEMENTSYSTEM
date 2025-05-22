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
    public partial class AddorRemoveCourse: Form
    {
        public AddorRemoveCourse()
        {
            InitializeComponent();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            string course = txtaddcourse.Text;
            QController q = new QController();
            string a=q.AddCourse(course);
                if (a =="")
                {
                    MessageBox.Show("SOME PROBLEM OCCURED WHILE ADDING / ACTIVATING THE COURSE");

                }
                else
                {
                    MessageBox.Show(a);

                }

            showcourses();

        }

        private void AddorRemoveCourse_Load(object sender, EventArgs e)
        {
            showcourses();
        }
        void showcourses()
        {

            QController q = new QController();

            dataGridView1.DataSource = q.TShowCourses().Tables[0];


        }
        

        private void REMOVE_Click(object sender, EventArgs e)
        {
            string course = txtremovecourse.Text;

            QController q = new QController();
            string a = q.RemoveCourse(course);
                MessageBox.Show(a);

            txtremovecourse.Text = "";
            showcourses();
        }
    }
}
