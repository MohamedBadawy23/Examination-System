using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int _Time , int _NumbeOfQuestions) : base(_Time , _NumbeOfQuestions)
        {
            
        }
        public override void CreateListOfQuestions()
        {
            Questions = new MCQQuestion[NumberOfQuestions];
            for (int i = 0; i < Questions?.Length; i++)
            {
                Questions[i] = new MCQQuestion();
                Questions[i].AddQuestion();
            }

            Console.Clear();

        }

        public override void ShowExam()
        {
            foreach (var question in Questions) 
            {
                // Question
                Console.WriteLine(question);
                // Choices
                for (int i = 0; i < question?.Answers?.Length; i++)
                    Console.WriteLine(question.Answers[i]);
                Console.WriteLine("------------------------------------");
                int UserAnswerId;

                do
                {
                    Console.WriteLine("Please Enter Answer Id");

                } while (!(int.TryParse(Console.ReadLine(), out UserAnswerId) && (UserAnswerId is 1 or 2 or 3)));

                question.UserAnswer.Id = UserAnswerId;
                question.UserAnswer.Text = question.Answers[UserAnswerId -1].Text;

            }

            Console.Clear() ;

            Console.WriteLine("Right Answers");

            for (int i = 0;i < Questions?.Length; i++)
            {
                Console.WriteLine($"Question Number {i + 1} : {Questions[i].Body}");

                Console.WriteLine($"Right Answer => {Questions[i].RightAnswer.Text}");

                Console.WriteLine("---------------------------------------------------------");
            }
        }
    }
}
