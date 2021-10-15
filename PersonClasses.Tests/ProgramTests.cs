using System;
using System.Collections.Generic;
using System.Text;
using PersonClasses;
using Xunit;

namespace PersonClasses.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void DivideTests()
        {
            double num1 = 1;
            double num2 = 3;
            double expected = 0.3333;

            double result = Program.Divide(num1, num2);

            Assert.Equal(expected, result, 4);

        }

        [Fact]
        public void DivideTestsZero()
        {
            double num1 = 1;
            double num2 = 0;

            double result = Program.Divide(num1, num2);

            Assert.True(double.IsInfinity(result));

        }
    }
}
