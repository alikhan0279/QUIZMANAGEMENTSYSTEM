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
using System.Text.RegularExpressions;

namespace QUIZMANAGEMENTSYSTEM
{
    public partial class Form1 : Form
    {

        public QController cobj = new QController();
        public static int rollno=0;
        public string user;
        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnsignups_Click(object sender, EventArgs e)
        {
            Studentsignup s = new Studentsignup();
            s.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelst.Hide();
            panelt.Hide();

        }

        private void btnsignupt_Click(object sender, EventArgs e)
        {
            Teachersignup t = new Teachersignup();
            t.Show();
        }

        private void btnlogins_Click(object sender, EventArgs e)
        {

           
            string username = txtrollnos.Text;
            string password = txtpasswords.Text;
            QController c = new QController();

            string a = c.UserLogin(username,password,"student");
                MessageBox.Show(a);
               
           
        }




        private void cmbselectuser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbselectuser.Text == "Student")
            {
                user = "student";
                panelst.Show();
                panelt.Hide();
            }

            if (cmbselectuser.Text == "Teacher")
            {
                user = "teacher";
                panelt.Show();
                panelst.Hide();
            }

        }

        private void btnlogint_Click(object sender, EventArgs e)
        {
            string username = txtusernamet.Text;
            string password = txtpasswordt.Text;
            QController c = new QController();

            string a = c.UserLogin(username, password, "teacher");
            MessageBox.Show(a);
               
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Do you want to quit Quiz Management System", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (a == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void txtrollnos_TextChanged(object sender, EventArgs e)
        {

            bool isrollnovalid()
            {
                string stregex = @"^[0-9]+$";
                Regex re1 = new Regex(stregex);
                if (re1.IsMatch(txtrollnos.Text))
                {
                    return true;
                }
                else
                    return false;
            }

            if (isrollnovalid() == true)
            {
                rollno = int.Parse(txtrollnos.Text);
            }
            else
            {
                MessageBox.Show("kindly enter numbers");
            }
        }
    }
}
    
