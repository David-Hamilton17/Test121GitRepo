//Written by David Hamilton
//1/27/2025

namespace QuizCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            QuizCal quizCal = new QuizCal();
            quizCal.Quiz1 = 80.0;
            quizCal.Quiz2 = 80.5;
            quizCal.Quiz3 = 50.6;
            quizCal.Quiz4 = 90.5;


            Console.WriteLine("Total: " + quizCal.CalcTotal());
            Console.WriteLine("Average: " + quizCal.CalcAverage());
            Console.WriteLine("Grade: " + quizCal.CalcLetterGrade());



            Console.WriteLine("Hello, World!");
        }
    }
}
