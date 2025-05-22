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
    public partial class AddQuestion : Form
    {
      
        public string course;
        public int qno;
        public string ques;
        public string op1;
        public string op2;
        public string op3;
        public string op4;
        public string ans;

        public AddQuestion()
        {
            InitializeComponent();
        }

        private void AddQuestion_Load(object sender, EventArgs e)
        {
            List<String> list = new List<String>();
            string state = "active";
            DBConnection c = DBConnection.DBobj();
            SqlConnection con = c.DBjoin();
            con.Open();
            string query = "SELECT course from courses where state='" + state + "' ";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader sdr = cmd.ExecuteReader();
            DataReaderAdapter datar = new DataReaderAdapter();
            list = datar.GetCourses(sdr);
            sdr.Close();
            con.Close();
            for (int i = 0; i < list.Count(); i++)
            {
                cmbselectcourse.Items.Add(list[i]);
            }

            labelquestion.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        public void cleartext()
        {
            txtquestion.Clear();
            txtop1.Clear();
            txtop2.Clear();
            txtop3.Clear();
            txtop4.Clear();
            txtanswer.Clear();

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (cmbselectcourse.Text == "" || txtquestion.Text == "" || txtop1.Text == "" || txtop2.Text == "" || txtop3.Text == "" || txtop4.Text == "" || txtanswer.Text == "")
            {
                MessageBox.Show("Kindly enter all the fields");
            }
            else
            {
                course = cmbselectcourse.Text;
                ques = txtquestion.Text;
                op1 = txtop1.Text;
                op2 = txtop2.Text;
                op3 = txtop3.Text;
                op4 = txtop4.Text;
                ans = txtanswer.Text;

                DBConnection c = DBConnection.DBobj();
                SqlConnection con = c.DBjoin();
                con.Open();
                string query = "INSERT INTO questions(Qno,Question,Option1,Option2,Option3,Option4,Answer,Course) values('" + qno + "','" + ques + "' , '" + op1 + "' ,'" + op2 + "' ,'" + op3 + "', '" + op4 + "','" + ans + "','" + course + "')";
                SqlCommand cmd = new SqlCommand(query, con);

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Question  addedd", "Success");
                    con.Close();
                    cleartext();
                }
                else
                {
                    MessageBox.Show("Some problem occured while adding question", "Error");
                }
              
                cleartext();
                qno=qno+1;
                labelquestion.Text = qno.ToString();
            }
            

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("if you have not saved question by clicking next, your data will be lost", "warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(a ==DialogResult.Yes)
            {
                cleartext();
            }
        }

        private void btnfinish_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Question course will be changed, do you want to change quiz", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (a == DialogResult.Yes)
            {

                cmbselectcourse.Text="";
                labelquestion.Text = "1";
                cleartext();
            }
         

        }

        

        private void labelquestion_Click(object sender, EventArgs e)
        {

        }
        
        

        private void cmbselectcourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnection c = DBConnection.DBobj();
            SqlConnection con = c.DBjoin();


            con.Open();
            string query = "select Qno from questions where Course='" + cmbselectcourse.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0 && ds.Tables[0].Rows[0][0].ToString() != "")
            {
                labelquestion.Text = (ds.Tables[0].Rows.Count + 1).ToString();
                qno = int.Parse(labelquestion.Text.ToString());
            }
            else
            {
                labelquestion.Text = "1";
                qno = int.Parse(labelquestion.Text.ToString());

            }
            con.Close();

        }
    }
    }

