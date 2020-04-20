using System;
using System.Collections.Generic;
using System.Text;
using DRT.Domain.Enums;

namespace DRT.Domain.Entities
{
    public class Case
    {
        public Case()
        {
            Notes = new HashSet<CaseNote>();
        }

        public int CaseId { get; set; }
        public string UserFriendlyId { get; set; }
        public string Title { get; set; }
        public int AccountId { get; set; }
        public int? UserId { get; set; }
        public DateTime OpenedDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public PriorityLevel Priority { get; set; }
        public Classification Classification { get; set; }

        public Account Account { get; set; }
        public User User { get; set; }
        public ICollection<CaseNote> Notes { get; set; }
    }
}
