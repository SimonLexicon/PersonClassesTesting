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
            //Person stud1 = new Person();
            //Console.WriteLine("Person.IdCounter" + Person.IdCounter);
            //Person stud2 = new Person("Skövde Lexicon", 1999, "Doctor Specialist");
            //Console.WriteLine("Person.IdCounter"+Person.IdCounter);

            //Console.WriteLine(stud1.Information());
            //Console.WriteLine();
            //Console.WriteLine(stud2.Information());

            //stud1.Classroom = "Göteborg Lexicon";


            Person simon = new Person("Classrom 1", 1789, "Science");
            Person simon2 = new Person("Classrom 1", 1789, "Science");
            Person simon3 = new Person("Classrom 1", 1789, "Science");

            Person[] container = new Person[10];

            container[0] = simon;
            container[1] = simon2;
            container[2] = simon3;


            for (int i = 0; i < container.Length; i++)
            {
                if(container[i] == null)
                {
                    continue;
                }
                else
                {
                    if(container[i].Id == 1)
                    {
                        Console.WriteLine(container[i].startYear);
                    }

                }
            }


            Console.ReadKey();
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
