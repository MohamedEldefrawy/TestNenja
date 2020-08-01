using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace TestNinja.Fundamentals
{
    public class Reservations
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            if (user.IsAdmin)

                return true;

            return  MadeBy == user;
        }
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}
