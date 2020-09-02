using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.NUnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private FizzBuzz fizzBuzz;

        [SetUp]
        public void SetUp()
        {
            this.fizzBuzz = new FizzBuzz();
        }

        [Test]
        [TestCase(15, "FizzBuzz")]
               public void GetOutput_WhenCalled_ReturnFizzBuzzIfInputDivisableByThreeAndFive(int number, string expected)
        {
            var result = FizzBuzz.GetOutput(number);
            Assert.AreEqual(result, expected);
        }

        [Test]
        [TestCase(3, "Fizz")]
        public void GetOutput_WhenCalled_ReturnFizzIfInputDivisableByThree(int number, string expected)
        {
            var result = FizzBuzz.GetOutput(number);
            Assert.AreEqual(result, expected);
        }

        [Test]
        [TestCase(5, "Buzz")]
        public void GetOutput_WhenCalled_ReturnBuzzIfInputDivisableByFive(int number, string expected)
        {
            var result = FizzBuzz.GetOutput(number);
            Assert.AreEqual(result, expected);
        }

        [Test]
        [TestCase(2, "2")]
        public void GetOutput_WhenCalled_ReturnNumberIfInputNotDivisableByFiveOrThree(int number, string expected)
        {
            var result = FizzBuzz.GetOutput(number);
            Assert.AreEqual(result, expected);
        }
    }
}
