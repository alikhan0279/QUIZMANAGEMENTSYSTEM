using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZMANAGEMENTSYSTEM
{//This is a Concrete State that represents when a course is not available for quiz attempt.
    // Represents a state where the quiz is deactivated
    public class InactiveState : State
    {
        public override string ShowQuiz(Course course)
        {
            // When quiz is inactive, display this message
            return "This quiz is deactivated";
        }
    }
}

