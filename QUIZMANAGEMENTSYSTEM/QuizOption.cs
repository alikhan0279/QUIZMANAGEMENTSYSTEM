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
    public partial class QuizOption : Form
    {
        public static string course;
        public QuizOption()
        {
            InitializeComponent();
        }

        private void QuizOption_Load(object sender, EventArgs e)
        {
            List<String> list = new List<String>();
            QController q = new QController();
            list = q.SShowCourses();

            for (int i = 0; i < list.Count(); i++)
            {
                cmbselectcourse.Items.Add(list[i]);
            }

            //cmbselectcourse.Text = cmbselectcourse.Items[0].ToString();



        }

        private void btnlogins_Click(object sender, EventArgs e)
        {
            if (cmbselectcourse.Text == "")
            {
                MessageBox.Show("Kindly select course of quiz");
                return;
            }

            course = cmbselectcourse.Text;

            Course c = new Course();
            State currentState = c.GetCurrentState(course); // Get current State object based on DB
            c.Setstate(currentState);

            string message = currentState.ShowQuiz(c);
            MessageBox.Show(message);

            if (currentState is Activestate)
            {
                this.Hide();

                // Strategy Pattern — run selected quiz type
                QController q = new QController();
                q.StartSelectedQuiz(course);
            }
        }





        private void cmbselectcourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
