using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZMANAGEMENTSYSTEM
{//This is another Concrete Strategy for CS quiz.
    // This class implements CS Quiz logic using the strategy interface
    public class CSQuizStrategy : IQuizStrategy
    {
        public void StartQuiz()
        {
            // CS-specific quiz logic goes here
            MessageBox.Show("Computer Science Quiz Started!"); // For now, we just show a message
        }
    }
}

