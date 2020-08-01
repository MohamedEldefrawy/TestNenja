using System;
using NUnit.Framework;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.NUnitTests
{
    [TestFixture]
    public class MathTests
    {

        private Math _math;

        [SetUp]
        public void Setup()
        {
            _math = new Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnSumOFTwoNumbers()
        {
            // Act 
            var result = _math.Add(5, 5);

            // Assert 
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnFirstArgument()
        {

            // Act 
            var result = _math.Max(5, 1);

            // Assert 
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        {

            // Act 
            var result = _math.Max(5, 10);

            // Assert 
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        {
            // Act 
            var result = _math.Max(5, 5);

            // Assert 
            Assert.That(result, Is.EqualTo(5));
        }
    }
}
