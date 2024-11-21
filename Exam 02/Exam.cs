using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02
{
    public abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }

        public Exam(int _Time , int _NumberOfQuestions)
        {
            Time = _Time ;
            NumberOfQuestions = _NumberOfQuestions ;
        }

        public abstract void CreateListOfQuestions();
        public abstract void ShowExam();
    }
}
