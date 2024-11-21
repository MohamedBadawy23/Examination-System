using System.Diagnostics;

namespace Exam_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject Sub01 = new Subject(1, "C#");

            Sub01.CreateExam();

            Console.Clear();

            char Char;
            do
            {
                Console.WriteLine("Do You Want To Start Exam (Y | N) ");
                
            } while (!(char.TryParse(Console.ReadLine(), out Char) && (Char == 'y' || Char == 'n')));

            if(Char == 'y')
            {
                Console.Clear();

                Stopwatch sw = new Stopwatch();

                sw.Start();

                Sub01.Exam.ShowExam();

                sw.Stop();

                Console.WriteLine($"Time = {sw.Elapsed}");
            }

            Console.WriteLine("Thank You");

        }
    }
}
