namespace DRT.Domain.Entities
{
    public class AccountUser
    {
        public int AccountUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public int AccountId { get; set; }

        public Account Account { get; set; }
    }
}