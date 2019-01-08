using System;

namespace App1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var student = new Student(Education.PhD, "CS01", 140000);
            Console.WriteLine(student);
            Console.WriteLine("-----------------------------------------------");
            Examination[] examList = {new Examination(),
                new Examination(3, "computer Science","Doe J. M.", 99, false, DateTime.Today)};
            student.AddExams(examList);
            Console.WriteLine("Exams student has taken:");
            foreach (var exam in student.TakenExams)
            {
                Console.WriteLine(exam);
            }
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Full student info:");
            student.PrintFullInfo();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Task 3:");
            IMarkName mark = student.TakenExams[0];
            Console.WriteLine("Mark in National scale:");
            Console.WriteLine(mark.NationalScaleName());
            Console.WriteLine("Mark in ECTS scale:");
            Console.WriteLine(mark.EctsScaleName());
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Task 4:");
            try
            {
                Console.WriteLine("Attempting to create student with Record-Book number 1");
                var badStudent = new Student(Education.PhD, "CS01", 1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Task 6:");
            Console.WriteLine("Exams taken with grade below 70:");
            Console.WriteLine(student.GetExamGradeLT(70));
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Task 11:");
            Console.WriteLine($"{student.Name} {student.Surname} is {student.GetAge()} years old");
        }
    }
}

//TODO how do I show off interface
//TODO sealed readonly internal
//TODO how do I invoke toString() for the list
//16