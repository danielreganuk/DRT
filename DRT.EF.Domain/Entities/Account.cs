using System;
using System.Collections.Generic;

namespace DRT.Domain.Entities
{
    public class Account
    {
        public Account()
        {
            Users = new HashSet<AccountUser>();
        }

        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public AccountType AccountType { get; set; }
        public string DefaultEmailAddress { get; set; }
        public string DefaultPhoneNo { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Active { get; set; }

        public ICollection<AccountUser> Users { get; set; }
    }
}