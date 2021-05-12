using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamQuiz.Quiz.Sections
{
    class History : Question
    {
        Dictionary<string, List<Answer>> questions = new Dictionary<string, List<Answer>>();

        public void FirstQuestion()
        {
            QuestionText = "вопрос 1";
            List<Answer> answers1 = new List<Answer>
            {
                new Answer
                {
                    AnswerText = "ответ1",
                    CorrectAnswer = false
                },
                new Answer
                {
                    AnswerText = "ответ2",
                    CorrectAnswer = true
                },
                new Answer
                {
                    AnswerText = "ответ3",
                    CorrectAnswer = false
                },
                new Answer
                {
                    AnswerText = "ответ4",
                    CorrectAnswer = false
                },
            };
            Console.WriteLine(QuestionText);
            foreach (var item in answers1)
            {
                Console.WriteLine($"{item.AnswerText}");
            }

            int choise = Int32.Parse(Console.ReadLine());
            if (answers1[choise].CorrectAnswer == true)
            {
                Console.WriteLine("Правильный ответ!");
            }
            else
                Console.WriteLine("Неправильный ответ!");
        }


    }
}
