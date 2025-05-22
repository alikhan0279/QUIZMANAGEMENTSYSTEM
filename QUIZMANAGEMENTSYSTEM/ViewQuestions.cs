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
    public partial class ViewQuestions : Form
    {
        public ViewQuestions()
        {
            InitializeComponent();
        }

        private void ViewQuestions_Load(object sender, EventArgs e)
        {
            ShowQuestions();

        }
         void ShowQuestions()
        {

            QController q = new QController();
            dataGridView1.DataSource = q.ShowallQuestions().Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string course = txtcourse.Text;
            int qno = int.Parse(txtqno.Text);
            QController q = new QController();
            string a=q.DeleteQuestion(course, qno);
            MessageBox.Show(a);
            ShowQuestions();
        }

        private void txtrollno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
