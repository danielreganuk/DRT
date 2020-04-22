using DRT.Domain.Enums;
using System;

namespace DRT.Domain.Entities
{
    public class TicketNote
    {
        public int TicketNoteId { get; set; }
        public TicketType NoteType { get; set; }
        public string Content { get; set; }
        public DateTime NoteDate { get; set; }
        public User User { get; set; }
        public AccountUser AccountUser { get; set; }
    } 
}