using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QUIZMANAGEMENTSYSTEM
{
    public abstract class Person
    {
        public Resultinfo resultinfo; // Product reference

        // Factory Method
        public abstract DataSet ViewResult();
    }

}
