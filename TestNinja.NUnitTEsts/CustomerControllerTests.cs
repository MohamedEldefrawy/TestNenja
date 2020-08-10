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
        private CustomerController _customerController;

        [SetUp]
        public void SetUp()
        {
            _customerController = new CustomerController();
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnningOkResponse()
        {
            var result = _customerController.GetCustomer(10);
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<CustomerController.Ok>());
            Assert.That(result, Is.InstanceOf<CustomerController.Ok>());
        }

        [Test]
        public void GetCustomer_IdIsZero_ReturnningNotFoundResponse()
        {
            var result = _customerController.GetCustomer(0);
            Assert.That(result, Is.Not.Null);

            // IS NotFound object
            Assert.That(result, Is.TypeOf<CustomerController.NotFound>());

            // Is NotFound or one of it's derivatives 
            Assert.That(result, Is.InstanceOf<CustomerController.NotFound>());
        }
    }
}
