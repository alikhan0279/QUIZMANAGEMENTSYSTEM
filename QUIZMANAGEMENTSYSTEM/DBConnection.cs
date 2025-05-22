using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;
using System.Data.SqlClient;


namespace QUIZMANAGEMENTSYSTEM
{

    public class DBConnection
    {
        private static DBConnection _instance;
        private static readonly object _lock = new object(); // Ensures thread safety
        private SqlConnection _connection;

        // Private constructor so no one can instantiate directly
        private DBConnection()
        {
            _connection = new SqlConnection("Data Source=ALI\\SQLEXPRESS;Initial Catalog=quizmanagementsystemDB;Integrated Security=True");
        }

        // Static method to get the single instance
        public static DBConnection DBobj()
        {
            if (_instance == null)
            {
                lock (_lock) // Lock to prevent race condition
                {
                    if (_instance == null)
                    {
                        _instance = new DBConnection();
                    }
                }
            }
            return _instance;
        }

        // Public method to access the connection
        public SqlConnection DBjoin()
        {
            return _connection;
        }
    }

}
