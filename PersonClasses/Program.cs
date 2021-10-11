using System;
using PersonClasses.Model;

namespace PersonClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            ToDoIt todoit = new ToDoIt();


            Console.WriteLine("Hello World!");
            Person stud1 = new Person();
            Console.WriteLine("Person.IdCounter" + Person.IdCounter);
            Person stud2 = new Person("Skövde Lexicon", 1999, "Doctor Specialist");
            Console.WriteLine("Person.IdCounter"+Person.IdCounter);

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
