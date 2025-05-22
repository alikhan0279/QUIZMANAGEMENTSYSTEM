using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZMANAGEMENTSYSTEM
{//This is a Concrete Strategy for Math quiz.
    // This class implements Math Quiz logic using the strategy interface
    public class MathQuizStrategy : IQuizStrategy
    {
        public void StartQuiz()
        {
            // Math-specific quiz logic goes here
            MessageBox.Show("Math Quiz Started!"); // For now, we just show a message
        }
    }
}

