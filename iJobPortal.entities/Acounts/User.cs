using System;
using System.Collections.Generic;
using System.Text;

namespace iJobPortal.entities.Acounts
{
    public class User
    {
        public Profile profile { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Address> address { get; set; }

    }
}
