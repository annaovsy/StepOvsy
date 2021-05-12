using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamQuiz.Quiz
{
    class Answer
    {
        public string AnswerText { get; set; }
        public bool CorrectAnswer { get; set; }
     

        public bool IsCorrect(bool correctAnswer)
        {
            if (correctAnswer)
                return true;
            else
                return false;
        }
    }
}
