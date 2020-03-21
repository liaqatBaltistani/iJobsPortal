using System;
using System.Collections.Generic;
using System.Text;

namespace iJobPortal.entities.Acounts
{
    public class Profile
    {
        public int Id { get; set; }
        public string ProfileTitle { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
    }

}
