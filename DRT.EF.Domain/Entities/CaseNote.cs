using System;

namespace DRT.Domain.Entities
{
    public class CaseNote
    {
        public int CaseNoteId { get; set; }
        public DateTime NoteDate { get; set; }
        public int CaseId { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }

        public Case Case { get; set; }
        public User User { get; set; }
    }
}