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
    public class CustomerControllerTests
    {
        private CustomerController _CustomerController;

        [SetUp]
        public void SetUp()
        {
            _CustomerController = new CustomerController();
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnningOkResponse()
        {
            var result = _CustomerController.GetCustomer(10);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<CustomerController.Ok>());
            Assert.That(result, Is.InstanceOf<CustomerController.Ok>());
        }

        [Test]
        public void GetCustomer_IdIsZero_ReturnningNotFoundResponse()
        {
            var result = _CustomerController.GetCustomer(0);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<CustomerController.NotFound>());
            Assert.That(result, Is.InstanceOf<CustomerController.NotFound>());
        }
    }
}
