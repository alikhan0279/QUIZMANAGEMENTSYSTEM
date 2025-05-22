using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QUIZMANAGEMENTSYSTEM
{
    // TeacherResultinfo class inherits from Resultinfo class
    public class TeacherResultinfo : Resultinfo
    {
        // It overrides ShowResultinfo() to return all quiz results from the database.
        public override DataSet ShowResultinfo()
        {
            // Getting singleton DB connection object
            DBConnection c = DBConnection.DBobj();
            SqlConnection con = c.DBjoin();
            con.Open();

            // Query to fetch all quiz results (teacher view)
            string query = "SELECT * from QuizResult";
            SqlCommand cmd = new SqlCommand(query, con);
            
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            con.Close();
            return ds;
        }
    }

}
