using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZMANAGEMENTSYSTEM
{ // This is the Context class, which uses the selected strategy at runtime.


    // This class maintains a reference to the current strategy
    public class QuizContext
    {
        private IQuizStrategy _strategy; // Reference to a quiz strategy

        // This method sets the strategy at runtime
        public void SetStrategy(IQuizStrategy strategy)
        {
            _strategy = strategy;
        }

        // This method executes the selected strategy
        public void ExecuteStrategy()
        {
            _strategy?.StartQuiz(); // Calls the StartQuiz method of the current strategy
        }
    }
}


