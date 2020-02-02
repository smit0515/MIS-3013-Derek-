using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkPT2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;
            int id;
            double quizzes, participations, homeworks, midterm, finalexam;

            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();

            Console.WriteLine("What is your student id?");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the overall percentage grade for your quizzes?");
            quizzes = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the overall percentage grade for your participations?");
            participations = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the overall percenatge grade for your midterm?");
            midterm = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the overall percentage grade for your homeworks?");
            homeworks = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the percentage grade for your final exam?");
            finalexam = double.Parse(Console.ReadLine());

            double finalGrade = (quizzes + participations + homeworks + midterm + finalexam) / 5;

            Console.WriteLine(firstName + lastName + "(" + id + "), your Final grade is:"+finalGrade.ToString("F")+"%");

            Console.WriteLine("Press any key to continue...");

            Console.ReadKey();









        }
    }
}
