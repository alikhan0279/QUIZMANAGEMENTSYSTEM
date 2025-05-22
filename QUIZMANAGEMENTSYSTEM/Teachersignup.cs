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
    public partial class Teachersignup : Form

    {
        public string name;
        public int empno;
        public string email;
        public Int64 contact;
        public string address;
        public string password;
        public Teachersignup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            address = txtaddress.Text;
            if (txtname.Text == "" || txtempno.Text == "" || txtemail.Text == "" || txtcontact.Text == "" || txtaddress.Text == "" || txtpassword.Text == "")
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


                

                if ( isemailvalid() == true)
                {
                    int a;
                    QController q = new QController();
                    a = q.AddTeacher(name, empno, email, contact, address, password);
                    if (a > 0)
                    {
                        MessageBox.Show("Teacher has been registered", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Some problem occured while regestring teacher", "Error");
                    }
                   
                }
            }
        }

        private void Teachersignup_Load(object sender, EventArgs e)
        {

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

        private void txtempno_TextChanged(object sender, EventArgs e)
        {
            bool isempnovalid()
            {
                string stregex = @"^[0-9]+$";
                Regex re1 = new Regex(stregex);
                if (re1.IsMatch(txtempno.Text))
                {
                    return true;
                }
                else
                    return false;
            }

            if (isempnovalid() == true)
            {
                empno = int.Parse(txtempno.Text);
            }
            else
            {
                MessageBox.Show("kindly enter numbers");
            }
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

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
    }
}
