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
    public partial class Sdashboard : Form
    {
        public Sdashboard()
        {
            InitializeComponent();
        }

        private void attemptQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SResult sr = new SResult();
            sr.Show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = 0;
            QController c = new QController();
            a = c.Checkifallquizateempted();
           
            if (a == 0)
            {
                MessageBox.Show("You have already attempted all your quizes");
            }
            else if (a == 1)
            {
                QuizOption q1 = new QuizOption();
                q1.Show();
            }

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sdashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
