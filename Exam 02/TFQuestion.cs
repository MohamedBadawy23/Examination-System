using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02
{
    public class TFQuestion : Question
    {
        public override string Header => $"True | False Question";

        public TFQuestion()
        {
            Answers = new Answer[2];
            Answers[0] = new Answer(1, "True");
            Answers[1] = new Answer(2, "False");
        }

        public override void AddQuestion()
        {
            // Header
            Console.WriteLine(Header);

            // Question Body
            do
            {
                Console.WriteLine("Please Enter Question Body");
                Body = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(Body));

            // Mark
            int mark;

            do
            {
                Console.WriteLine("Please Enter Question Mark");
                
            } while (!(int.TryParse(Console.ReadLine(), out mark) && (mark > 0)));
            Mark = mark;

            // Right Answer
            int rightAnswerId;

            do
            {
                Console.WriteLine("Please Enter The Right Answer Id (1 For True | 2 For False)");
                
            } while (!(int.TryParse(Console.ReadLine(), out rightAnswerId) && (rightAnswerId is 1 or 2)));

            RightAnswer.Id = rightAnswerId;
            RightAnswer.Text = Answers[rightAnswerId - 1].Text;
            Console.Clear();

        }
    }
}
