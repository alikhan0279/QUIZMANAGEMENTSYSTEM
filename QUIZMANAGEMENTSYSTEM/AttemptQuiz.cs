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
    public partial class AttemptQuiz : Form
    {
        public int prev_btnno;
        public int correctans = 0;
        public int wrongans = 0;
        public int points = 0;
        public int tmarks = 0;
        public int noques=0;
        public int qno=1;
        public string course;
        public string answer = "";
        public string opp1 = "";
        public string opp2 = "";
        public string opp3 = "";
        public string opp4 = "";
        
        public AttemptQuiz()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (qno<noques)
            {
                answercheck();
                qno = qno + 1;
                questionshow();
            }
            else
            {
                btnFinish.Show();
            }
            if (qno > 1)
            {
                btnprev.Show();
            }


        }
        public void getrollno()
        {
            Form1 f = new Form1();
            int a = int.Parse(f.txtrollnos.Text);
        }

        private void AttemptQuiz_Load(object sender, EventArgs e)
        {
            btnprev.Hide();
            labelca.Text = "0";
            labelwa.Text = "0";
            labelpoints.Text = "0";
            labelpercent.Text = "0";
            labelresult.Text = "0";
      
           
            btnFinish.Hide();
            labelrollno.Text = Form1.rollno.ToString();
            int srollno = int.Parse(labelrollno.Text);
            labelcourse.Text = QuizOption.course;
            course = QuizOption.course;

            DBConnection c = DBConnection.DBobj();
            SqlConnection con = c.DBjoin();
            con.Open();
            string query2 = "select Qno from questions where Course='" + course + "'";
            SqlCommand cmd3 = new SqlCommand(query2, con);
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd3);

            DataSet ds2 = new DataSet();
            adp2.Fill(ds2);
            if (ds2.Tables[0].Rows.Count != 0 && ds2.Tables[0].Rows[0][0].ToString() != "")
            {
                noques = int.Parse(ds2.Tables[0].Rows.Count.ToString());
            }
            con.Close();
            questionshow();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnFinish_Click(object sender, EventArgs e)
        {
            btnprev.Hide();
            button1.Hide();
            answercheck();
            labelca.Text = correctans.ToString();
            wrongans = noques - correctans;
            labelwa.Text = wrongans.ToString();
            labelpoints.Text = points.ToString();
            double totalmarks = 10 * noques;
            double percentage = ((points / totalmarks) * 100);
            labelpercent.Text = percentage.ToString();
            if (percentage <40)
            {
                labelresult.Text = "Failed";
            }
            else
            {
                labelresult.Text = "Passed";
            }
            int rollno = int.Parse(labelrollno.Text);
            string qcourse = labelcourse.Text;
            int nca = int.Parse(labelca.Text);
            int nwa = int.Parse(labelwa.Text);
            double per = double.Parse(labelpercent.Text);
            string result = labelresult.Text;
            DBConnection c = DBConnection.DBobj();
            SqlConnection con = c.DBjoin();
            con.Open();

            string query = "INSERT INTO QuizResult(Rollno,Noofcorrectans,Noofwrongans,Percentage,Result,Course) values('" + rollno + "','" + nca + "','" + nwa + "','" + per + "','" + result + "' , '" + qcourse + "' )";
            SqlCommand cmd = new SqlCommand(query, con);

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Quiz completed", "Success");
                con.Close();
            }
            else
            {
                MessageBox.Show("Your quiz is not stored", "Error");
            }
            
        }
        public void questionshow()
        {
            labelqno.Text = qno.ToString();
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
                labelques.Text = dss.Tables[0].Rows[0][1].ToString();
                btn1.Text = dss.Tables[0].Rows[0][2].ToString();
                btn2.Text = dss.Tables[0].Rows[0][3].ToString();
                btn3.Text = dss.Tables[0].Rows[0][4].ToString();
                btn4.Text = dss.Tables[0].Rows[0][5].ToString();
                answer = dss.Tables[0].Rows[0][6].ToString();
            }
            con.Close(); 

        }
        public void answercheck()
        {
            opp1 = btn1.Text;
            opp2 = btn2.Text;
            opp3 = btn3.Text;
            opp4 = btn4.Text;
            if (btn1.Checked && answer == opp1)
            {
                correctans += 1;
                points += 10;
                prev_btnno = 1;
            }

            else if (btn2.Checked && answer == opp2)
            {
                correctans += 1;
                points += 10;
                prev_btnno = 2;
            }

            else if (btn3.Checked && answer == opp3)
            {
                correctans += 1;
                points += 10;
                prev_btnno = 3;
            }

            else if (btn4.Checked && answer == opp4)
            {
                correctans += 1;
                points += 10;
                prev_btnno = 4;
            }
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            qno = qno - 1;
            string prev_answer = "";
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
                
                prev_answer = dss.Tables[0].Rows[0][6].ToString();
            }
             
            if (prev_btnno==1 && prev_answer == opp1)
            {
                correctans -= 1;
                points -= 10;
            }

            else if (prev_btnno==2 && prev_answer == opp2)
            {
                correctans -= 1;
                points -= 10;
            }

            else if (prev_btnno == 3 && prev_answer == opp3)
            {
                correctans -= 1;
                points -= 10;
            }

            else if (prev_btnno == 4 && prev_answer == opp4)
            {
                correctans -= 1;
                points -= 10;
            }
            con.Close();
            questionshow();

        }
    }
}
