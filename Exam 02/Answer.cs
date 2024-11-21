using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02
{
    public class Answer
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Answer(int _Id , string _Text)
        {
            Id = _Id ;
            Text = _Text ;
        }

        public Answer()
        {
            
        }

        public override string ToString()
            =>  $"{Id}-{Text}";
        
    }
}
