namespace ExpenseTracker.Components.model
{

    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; } 
        public string? Phone { get; set; }
        public string? Email { get; set; }

        public string? Address { get; set; }

        public string? Password { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}