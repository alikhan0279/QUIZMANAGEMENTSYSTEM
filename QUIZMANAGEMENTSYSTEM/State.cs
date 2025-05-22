using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZMANAGEMENTSYSTEM
{//This defines a common interface (ShowQuiz) that all quiz states must implement.
    // Abstract base class for all states in the State Pattern
    public abstract class State
    {
        // Declares a method every concrete state must implement
        public abstract string ShowQuiz(Course course);
    }
}

