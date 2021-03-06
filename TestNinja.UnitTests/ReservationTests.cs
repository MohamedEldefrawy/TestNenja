﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_True()
        {
            // Arrange
            var reservation = new Reservations();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void CanBeCancelledBy_SameUserCancellingReservation_True()
        {
            // Arrange 
            var user = new User();
            var reservation = new Reservations { MadeBy = user };

            // Act 
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void CanBeCancelledBy_OtherUserCancellingReservation_False()
        {
            // Arrange
            var reservation = new Reservations() { MadeBy = new User { } };

            // Act
            var result = reservation.CanBeCancelledBy(new User());

            // Assert 
            Assert.IsFalse(result);
        }
    }
}
