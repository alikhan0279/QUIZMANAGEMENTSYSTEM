using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QUIZMANAGEMENTSYSTEM
{
   public class Teacher:Person
    {
        // It uses TeacherResultinfo as the factory product to show all quiz results.
        public override DataSet ViewResult()
        {
            // Factory Method: creating Teacher-specific result product
            resultinfo = new TeacherResultinfo();
            return resultinfo.ShowResultinfo();
        }
        public int InsertTeacher(string name,int empno,string email,Int64 contact,string address,string password)
        {
            DBConnection c = DBConnection.DBobj();
            SqlConnection con = c.DBjoin();
            con.Open();
            string query = "INSERT INTO teacherinfo(Firstname,Employeeno,Email,Contact,Address,Password) values('" + name + "','" + empno + "','" + email + "' , '" + contact + "' ,'" + address + "' ,'" + password + "')";
            SqlCommand cmd = new SqlCommand(query, con);

            int a = cmd.ExecuteNonQuery();
            con.Close();
            return a;
        }
    }
}
