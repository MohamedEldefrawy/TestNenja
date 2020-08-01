using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.NUnitTEsts
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        private HtmlFormatter _formatter;

        [SetUp]
        public void SetUp()
        {
            _formatter = new HtmlFormatter();
        }
        [Test]

        [TestCase("HelloWorld!", "<strong>HelloWorld!</strong>")]
        public void HtmlFormatter_WhenCalled_ShouldEncloseTheStringWithStrongElement(string input, string expected)
        {
            var result = _formatter.FormatAsBold(input);
            Assert.That(result, Is.EqualTo(expected).IgnoreCase);
        }
    }
}
