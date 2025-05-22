using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QUIZMANAGEMENTSYSTEM
{
    public class Course
    {
        private State state;// Holds current state object

        // Sets the current state
        public void Setstate(State state)
        {
            this.state = state;
        }


        // Gets the current state based on course name (from database)
        public State GetCurrentState(string courseName)
        {
            State state;
            DBConnection c = DBConnection.DBobj();
            SqlConnection con = c.DBjoin();
            con.Open();
            string query = "SELECT state FROM courses WHERE course = '" + courseName + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string stateStr = reader["state"].ToString().ToLower();
                if (stateStr == "active")
                {
                    state = new Activestate();
                }
                else
                {
                    state = new InactiveState();
                }
            }
            else
            {
                state = new InactiveState(); // default if no course found
            }

            reader.Close();
            con.Close();
            return state;
        }

        public List<string> GetCourses()
        {
            List<string> list = new List<string>();  

            int rno = Form1.rollno; 

            DBConnection c = DBConnection.DBobj(); // Singleton instance of your DB connection handler
            SqlConnection con = c.DBjoin(); 
            con.Open(); 
            string query = "SELECT course FROM courses WHERE course NOT IN(SELECT Course FROM QuizResult WHERE Rollno='" + rno + "') ";

            SqlCommand cmd = new SqlCommand(query, con); 

            SqlDataReader sdr = cmd.ExecuteReader(); 

            //Object Adapter Pattern 
            CCourses adapter = new DataReaderAdapter();  // Create an instance of the adapter class (using interface reference)

            list = adapter.GetCourses(sdr);  // Call the adapter method to convert SqlDataReader to List<string>

            sdr.Close(); 
            con.Close(); 
            return list; 
        }


        public string InsertCourse(string course)
        {
            string s = "";
            string state = "active";
            int flag = checkifcourseexists(course);
            DBConnection c = DBConnection.DBobj();
            SqlConnection con = c.DBjoin();

            if (flag == 0)
            {
                con.Open();
                string query = "INSERT INTO courses(course,state) values('" + course + "', '" + state + "')";
                SqlCommand cmd = new SqlCommand(query, con);

                 int a = cmd.ExecuteNonQuery();
                if(a>0)
                {
                    s = "COURSE HAS BEEN ADDED";
                }
                con.Close();

            }
            else if (flag == 1)
            {
                string state2 = "active";
                con.Open();

                string query = "UPDATE courses SET state='" + state2 + "' where course='" + course + "' ";
                SqlCommand cmd = new SqlCommand(query, con);

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    s = "COURSE IS ACTIVATED";
                }
                con.Close();

            }
            return s;
        }
            int checkifcourseexists(string course)
            {
                int a = 0;
                string query = "SELECT * from courses where course = '" + course + "'  ";
                DBConnection c = DBConnection.DBobj();
                SqlConnection con = c.DBjoin();
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    a = 1;

                }
                con.Close();
                return a;
            }
        public DataSet TShowCourses()
        {
            DBConnection c = DBConnection.DBobj();
            SqlConnection con = c.DBjoin();
            con.Open();

            string query = "SELECT * from courses";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            con.Close();
           return ds;
           
        }
        public string DeleteCourse(string course)
        {
            string s = "";
            string state = "inactive";
            DBConnection c = DBConnection.DBobj();
            SqlConnection con = c.DBjoin();
            con.Open();

            string query = "UPDATE courses SET state='" + state + "' where course='" + course + "' ";
            SqlCommand cmd = new SqlCommand(query, con);

            int a = cmd.ExecuteNonQuery();
            con.Close();
            if (a > 0)
            {
                s="Course has been deactivated";

            }
            else
            {
                s="Some problem occured while deactivating course";

            }
            return s;
        }
        }
}
