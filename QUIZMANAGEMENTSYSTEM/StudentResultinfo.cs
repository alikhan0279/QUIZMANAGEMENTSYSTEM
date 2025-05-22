using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QUIZMANAGEMENTSYSTEM
{
    public class StudentResultinfo : Resultinfo
    {
        //It overrides ShowResultinfo() to return only the current student’s quiz result from the database.
        public override DataSet ShowResultinfo()
        {
            // Getting roll number from Form1 (UI)
            int rno = Form1.rollno;

            // Getting singleton DB connection object
            DBConnection c = DBConnection.DBobj();
            SqlConnection con = c.DBjoin();
            con.Open();

            // Query to fetch only student-specific result
            string query = "SELECT * from QuizResult where Rollno='" + rno + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            con.Close();
            return ds;
        }
    }

}
