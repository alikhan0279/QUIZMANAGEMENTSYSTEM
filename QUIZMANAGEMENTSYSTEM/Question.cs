using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QUIZMANAGEMENTSYSTEM
{
    public class Question
    {
        public DataSet ShowallQuestions()
        {
            DBConnection c = DBConnection.DBobj();
            SqlConnection con = c.DBjoin();
            con.Open();

            string query = "SELECT * from questions";

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            con.Close();
            return ds;
        }
        public string DeleteQuestion(string course,int qno)
        {
            string s = "";
            DBConnection c = DBConnection.DBobj();
            SqlConnection con = c.DBjoin();
            con.Open();
            string query = "DELETE from questions where Course='" + course + "' AND Qno='" + qno + "' ";
            SqlCommand cmd = new SqlCommand(query, con);

           int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
               s="Question deleted";
                con.Close();
            }
            else
            {
                s="Some problem occured while deleting question";
            }
            return s;
        }
    }
}
