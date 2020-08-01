using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.NUnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_True()
        {
            // Arrange
            var reservation = new Reservations();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert
            Assert.That(result, Is.True);
        }


        [Test]
        public void CanBeCancelledBy_SameUserCancellingReservation_True()
        {
            // Arrange 
            var user = new User();
            var reservation = new Reservations { MadeBy = user };

            // Act 
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.That(result, Is.True);
        }


        [Test]
        public void CanBeCancelledBy_OtherUserCancellingReservation_False()
        {
            // Arrange
            var reservation = new Reservations() { MadeBy = new User { } };

            // Act
            var result = reservation.CanBeCancelledBy(new User());

            // Assert 
            Assert.That(result, Is.False);
        }

    }
}
