using System;
using System.Data;
using System.Data.SqlClient;

namespace QUIZMANAGEMENTSYSTEM
{
    public class RealLogin
    {
        public string Authenticate(string username, string password, string user)
        {
            string result = "";
            DBConnection c = DBConnection.DBobj();
            SqlConnection con = c.DBjoin();
            con.Open();

            string query = "";

            if (user == "teacher")
            {
                query = "SELECT * from teacherinfo where Firstname = @username AND Password = @password";
            }
            else if (user == "student")
            {
                query = "SELECT * from sinfo where Rollno = @username AND Password = @password";
            }
            else
            {
                return "Invalid user type";
            }

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                if (user == "student")
                {
                    Sdashboard snewform = new Sdashboard();
                    snewform.Show();
                }
                else if (user == "teacher")
                {
                    Tdashboard tnewform = new Tdashboard();
                    tnewform.Show();
                }
                result = "LOGIN SUCCESSFUL, SUCCESS";
            }
            else
            {
                result = "WRONG USERNAME OR PASSWORD, LOGIN UNSUCCESSFUL";
            }
            con.Close();

            return result;
        }
    }
}
