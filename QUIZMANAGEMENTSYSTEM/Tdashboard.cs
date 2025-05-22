using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZMANAGEMENTSYSTEM
{
    public partial class Tdashboard : Form
    {
        public Tdashboard()
        {
            InitializeComponent();
        }

        private void addQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Question uq= new Update_Question();
            uq.Show();
        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddQuestion aq = new AddQuestion();
            aq.Show();
            
        }

        private void Tdashboard_Load(object sender, EventArgs e)
        {

        }

        private void resultToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TResult tr = new TResult();
            tr.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddorRemoveCourse ad = new AddorRemoveCourse();
            ad.Show();
        }

        private void viewQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewQuestions vq = new ViewQuestions();
            vq.Show();
        }

        private void viewStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studentdetails sd = new Studentdetails();
            sd.Show();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
