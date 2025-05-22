using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QUIZMANAGEMENTSYSTEM
{
    public partial class Studentsignup : Form
    {
        public string name;
        public int rollno;
        public string semester;
        public string department;
        public string email;
        public Int64 contact;
        public string password;
        public Studentsignup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtname.Text == "" || txtrollno.Text == "" || txtsemester.Text == "" || txtdepartment.Text == "" || txtemail.Text == "" || txtcontact.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Kindly enter all the fields");
            }
            else
            {

                bool isemailvalid()
                {
                    string stregex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
             @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
             @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"; ;
                    Regex re5 = new Regex(stregex);
                    if (re5.IsMatch(txtemail.Text))
                    {
                        return true;
                    }
                    else
                        return false;
                }

                if (isemailvalid() == true)
                {
                    email = txtemail.Text;
                }
                else
                {
                    MessageBox.Show("kindly enter correct email");
                }

                if (isemailvalid() == true)
                {
                    int a;
                    QController q = new QController();
                    a = q.AddStudent(name,rollno,semester,department,email, contact, password);
                    if (a > 0)
                    {
                        MessageBox.Show("Student has been added", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Some problem occured while adding student", "Error");
                    }
                    
                }
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            bool isnamevalid()
            {
                string stregex = @"^[a-zA-Z]";
                Regex re = new Regex(stregex);
                if (re.IsMatch(txtname.Text))
                {
                    return true;
                }
                else
                    return false;
            }

            if (isnamevalid() == true)
            {
                name = txtname.Text;
            }
            else
            {
                MessageBox.Show("kindly enter alphabets");
            }
        }

        private void txtrollno_TextChanged(object sender, EventArgs e)
        {

            bool isrollnovalid()
            {
                string stregex = @"^[0-9]+$";
                Regex re1 = new Regex(stregex);
                if (re1.IsMatch(txtrollno.Text))
                {
                    return true;
                }
                else
                    return false;
            }

            if (isrollnovalid() == true)
            {
                rollno = int.Parse(txtrollno.Text);
            }
            else
            {
                MessageBox.Show("kindly enter numbers");
            }
        }

        private void txtsemester_TextChanged(object sender, EventArgs e)
        {
            bool issemestervalid()
            {
                string stregex = @"^[a-zA-Z0-9]+$";
                Regex re3 = new Regex(stregex);
                if (re3.IsMatch(txtsemester.Text))
                {
                    return true;
                }
                else
                    return false;
            }

            if (issemestervalid() == true)
            {
                semester = txtsemester.Text;
            }
            else
            {
                MessageBox.Show("kindly enter correct semester name");
            }
        }

        private void txtdepartment_TextChanged(object sender, EventArgs e)
        {
            bool isdepartmentvalid()
            {
                string stregex = @"^[a-zA-Z]";
                Regex re4 = new Regex(stregex);
                if (re4.IsMatch(txtdepartment.Text))
                {
                    return true;
                }
                else
                    return false;
            }

            if (isdepartmentvalid() == true)
            {
                department = txtdepartment.Text;
            }
            else
            {
                MessageBox.Show("kindly enter alphabets");
            }
        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {
            bool iscontactnovalid()
            {
                string stregex = @"^[0-9]+$";
                Regex re6 = new Regex(stregex);
                if (re6.IsMatch(txtcontact.Text))
                {
                    return true;
                }
                else
                    return false;
            }

            if (iscontactnovalid() == true)
            {
                contact = Int64.Parse(txtcontact.Text);
            }
            else
            {
                MessageBox.Show("kindly enter correct phone number");
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            bool ispasswordvalid()
            {
                string stregex = @"^[A-Za-z0-9_@.\/$#&+-]+$";
                Regex re7 = new Regex(stregex);
                if (re7.IsMatch(txtpassword.Text))
                {
                    return true;
                }
                else
                    return false;
            }

            if (ispasswordvalid() == true)
            {
                password = txtpassword.Text;
            }
            else
            {
                MessageBox.Show("kindly donot enter spaces");
            }
        }

        private void Studentsignup_Load(object sender, EventArgs e)
        {

        }
    }
}
