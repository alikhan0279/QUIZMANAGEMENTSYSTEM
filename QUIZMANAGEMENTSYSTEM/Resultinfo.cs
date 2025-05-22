using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;

namespace QUIZMANAGEMENTSYSTEM
{
    // Abstract Product class
    public abstract class Resultinfo
    {
        // Factory method that will be overridden by concrete products
        public abstract DataSet ShowResultinfo();
    }

}
