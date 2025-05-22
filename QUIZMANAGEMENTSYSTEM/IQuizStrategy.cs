using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZMANAGEMENTSYSTEM
{ //This is the Strategy interface
    // This interface defines the common method that all quiz strategies must implement
    public interface IQuizStrategy
    {
        void StartQuiz(); // Abstract method to start the quiz (to be implemented differently in each strategy)
    }
}

