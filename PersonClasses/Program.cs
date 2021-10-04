using System;

namespace PersonClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student stud1 = new Student();
            Console.WriteLine("Student.IdCounter" + Student.IdCounter);
            Student stud2 = new Student("Skövde Lexicon", 1999, "Doctor Specialist");
            Console.WriteLine("Student.IdCounter"+Student.IdCounter);

            Console.WriteLine(stud1.Information());
            Console.WriteLine();
            Console.WriteLine(stud2.Information());

            stud1.Classroom = "Göteborg Lexicon";


            Console.ReadKey();
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
