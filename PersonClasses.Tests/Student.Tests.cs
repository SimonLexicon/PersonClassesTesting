using System;
using Xunit;
using PersonClasses;

namespace PersonClasses.Tests
{
    public class StudentTests
    {
        [Fact]
        public void Constructor()
        {
            string classroom = "A2";
            int startYear = 2020;
            string major = "Computer Science";

            Person testStudent = null;

            testStudent = new Person(classroom, startYear, major);

            Assert.NotNull(testStudent);
            Assert.Equal(testStudent.Classroom, classroom);
            Assert.Equal(testStudent.startYear, startYear);
            Assert.Equal(testStudent.major, major);
        }

        [Theory]
        [InlineData("")]
        public void ClassroomInputCheck(string classroom)
        {
            int startYear = 2020;
            string major = "Computer Science";

    
            ArgumentException result = Assert.Throws<ArgumentException>(
                () => new Person(classroom, startYear, major));

            Assert.Equal("classroom needs to be a valid room.", result.Message);

            
        }

        [Theory]
        [InlineData(null)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(-3)]
        [InlineData(99999999)]
        public void StartYearTest(int startYear)
        {
            string classroom = "A2";
            string major = "Computer Science";

            Person testStudent = null;

            testStudent = new Person(classroom, startYear, major);

            Assert.NotNull(testStudent);
            Assert.Equal(testStudent.startYear, startYear);

        }
    }
}
