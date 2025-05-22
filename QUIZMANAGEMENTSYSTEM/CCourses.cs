using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QUIZMANAGEMENTSYSTEM
{
    // Interface that defines a method contract for getting course data. This is the Target Interface in the Object Adapter pattern
    public interface CCourses
    {
        // Method that accepts a SqlDataReader and returns a list of course names
        List<string> GetCourses(SqlDataReader sdr);
    }
}
