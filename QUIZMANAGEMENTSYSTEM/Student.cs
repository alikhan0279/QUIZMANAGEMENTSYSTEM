using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QUIZMANAGEMENTSYSTEM
{
    public class Student:Person
    {
        public DataSet ViewAllStudentDetails()
        {
            DBConnection c = DBConnection.DBobj();
            SqlConnection con = c.DBjoin();
            con.Open();

            string query = "SELECT * from sinfo ";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adp.Fill(ds);
       
            con.Close();
            return ds;
        }
        public int DeleteStudent(int rollno)
        {
            DBConnection c = DBConnection.DBobj();
            SqlConnection con = c.DBjoin();
            con.Open();
            string query = "DELETE from sinfo where Rollno='" + rollno + "' ";
            SqlCommand cmd = new SqlCommand(query, con);

            int a = cmd.ExecuteNonQuery();
            con.Close();
            return a;
        }
        public int InsertStudent(string name, int rollno, string semester, string department, string email, Int64 contact, string password)
        {
            DBConnection c = DBConnection.DBobj();
            SqlConnection con = c.DBjoin();
            con.Open();

            string query = "INSERT INTO sinfo(Firstname,Rollno,Semester,Department,Email,Contactno,Password) values('" + name + "','" + rollno + "','" + semester + "','" + department + "','" + email + "' , '" + contact + "' , '" + password + "')";
            SqlCommand cmd = new SqlCommand(query, con);

            int a = cmd.ExecuteNonQuery();
            con.Close();
            return a;
        }

        // It implements ViewResult() by instantiating StudentResultinfo 
        public override DataSet ViewResult()
        {
            // Factory Method: creating Student-specific result product
            resultinfo = new StudentResultinfo();
            // Calls ShowResultinfo() to get the dataset of student results.
            return resultinfo.ShowResultinfo();
        }
        public int ifattemtedallquiz()
        {
            int a = 0;
            int rno = Form1.rollno;
            DBConnection c = DBConnection.DBobj();
            SqlConnection con = c.DBjoin();
            con.Open();
            string query = "SELECT course from courses WHERE course NOT IN(SELECT Course from QuizResult where Rollno='" + rno + "') ";
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
    }
}
