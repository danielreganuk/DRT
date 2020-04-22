using DRT.Domain.Enums;
using System;
using System.Collections.Generic;

namespace DRT.Domain.Entities
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string Subject { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public Account Account { get; set; }
        public AccountUser AccountUserOwner { get; set; }
        public User InternalUserOwner { get; set; }
        public PriorityLevel PriorityLevel { get; set; }
        public TicketType TicketType { get; set; }

        public ICollection<TicketNote> Notes { get; set; }
    }
}