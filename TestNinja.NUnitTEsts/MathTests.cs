﻿using System;
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
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterNumber(int a, int b, int expected)
        {

            // Act 
            var result = _math.Max(a, b);

            // Assert 
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
