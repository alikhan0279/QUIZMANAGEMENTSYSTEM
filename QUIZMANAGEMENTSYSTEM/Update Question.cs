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
    public partial class Update_Question : Form
    {
      


        public Update_Question()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string course = cmbselectcourse.Text;
            int qno = int.Parse(txtqno.Text);

            DBConnection c = DBConnection.DBobj();
            SqlConnection con = c.DBjoin();
            con.Open();
           
            
            if (cmbselectcourse.Text == "" || txtqno.Text == "" || txtquestion.Text == "" || txtop1.Text == "" || txtop2.Text == "" || txtop3.Text == "" || txtop4.Text == "" || txtanswer.Text == "")
            {
                MessageBox.Show("Kindly enter all the fields");
            }
            else
            {
                string ques = txtquestion.Text;
                string op1 = txtop1.Text;
                string op2 = txtop2.Text;
                string op3 = txtop3.Text;
                string op4 = txtop4.Text;
                string ans = txtanswer.Text;

                
                string query = "UPDATE questions SET Question='" + ques + "', Option1='" + op1 + "' , Option2='" + op2 + "', Option3='" + op3 + "', Option4='" + op4 + "', Answer='" + ans + "' where Course='" + course + "' AND Qno='" + qno + "' ";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Question  updated", "Success");
                    con.Close();

                }
                else
                {
                    MessageBox.Show("Some problem occured while updating question", "Error");
                }
               
            }
        }

        private void txtqno_TextChanged(object sender, EventArgs e)
        {
            string course = cmbselectcourse.Text;
            int qno = int.Parse(txtqno.Text);

            DBConnection c = DBConnection.DBobj();
            SqlConnection con = c.DBjoin();
            con.Open();
            string query = "SELECT * from questions where Course = '" + course + "' AND Qno='" + qno + "' ";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter adpp = new SqlDataAdapter(cmd);

            DataSet dss = new DataSet();
            adpp.Fill(dss);
            if (dss.Tables[0].Rows.Count != 0)
            {
                txtquestion.Text = dss.Tables[0].Rows[0][1].ToString();
                txtop1.Text = dss.Tables[0].Rows[0][2].ToString();
                txtop2.Text = dss.Tables[0].Rows[0][3].ToString();
                txtop3.Text = dss.Tables[0].Rows[0][4].ToString();
                txtop4.Text = dss.Tables[0].Rows[0][5].ToString();
                txtanswer.Text = dss.Tables[0].Rows[0][6].ToString();
            }
            else
            {
                MessageBox.Show("Kindly enter valid course and question number");
            }
            con.Close();

        }

        private void Update_Question_Load(object sender, EventArgs e)
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


        }
    }
}
