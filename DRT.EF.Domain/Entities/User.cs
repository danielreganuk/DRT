using System;
using System.Collections.Generic;
using System.Text;

namespace DRT.Domain.Entities
{
    public class User
    {
        public User()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
