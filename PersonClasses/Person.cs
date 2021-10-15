using System;
using System.Collections.Generic;
using System.Text;

namespace PersonClasses
{
    public class Person
    {
        static int idCounter = 0;
        public static int IdCounter { get { return idCounter; } }

        readonly int id;
        public int Id { get { return id; } }

        private string classroom;
        public string Classroom
        {
            get { return classroom; }
            set
            {
                if (value is null || value.Equals(""))
                {
                    throw new ArgumentException("classroom needs to be a valid room.");
                }
                classroom = value;
            }
        }

        public readonly string major;

        public int startYear;
        public int grade;

        public Person()
        {
            id = ++idCounter;
            this.classroom = "A2";
            this.startYear = 2020;
            this.grade = 0;
            this.major = "Computer Science";
        }
        public Person(string classroom, int startYear, string major)
        {
            id = ++idCounter;
            Classroom = classroom;
            this.startYear = startYear;
            this.grade = 0;
            this.major = major;
        }

        public string Information()
        {
            return $"Information student\n" +
                $"id: {id}\n" +
                $"classroom: {classroom}\n" +
                $"startYear: {startYear}\n" +
                $"grade: {grade}\n" +
                $"major: {major}";
        }

    }
}
