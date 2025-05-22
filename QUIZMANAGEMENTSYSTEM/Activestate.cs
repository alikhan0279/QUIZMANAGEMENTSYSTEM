using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZMANAGEMENTSYSTEM
{//This is the second Concrete State. If the course is active, it lets the student take the quiz.
    // Represents a state where the quiz is active and available
    public class Activestate : State
    {
        public override string ShowQuiz(Course course)
        {
            // Create and show the AttemptQuiz form (UI)
            AttemptQuiz aq = new AttemptQuiz();
            aq.Show();

            // Return success message
            return "You can attempt Quiz";
        }
    }
}

