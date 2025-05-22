using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QUIZMANAGEMENTSYSTEM
{
    // Adapter class that implements the interface CCourses
    public class DataReaderAdapter : CCourses
    {
        //It wraps the logic of reading from SqlDataReader, which is a library/database-specific class,
        //and converts it into the format system expects: List<string>

        // Implements GetCourses to adapt SqlDataReader into List<string>.
        // SqlDataReader, a low-level object from a database library, is adapted to a higher-level object List<string>.
        public List<string> GetCourses(SqlDataReader sdr)
        {
            List<string> list = new List<string>(); // List to store course names

           
            while (sdr.Read())
            {
                
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    
                    list.Add(sdr.GetString(i));
                }
            }
            return list; // Return the list of course names
            
        }
    }
}
