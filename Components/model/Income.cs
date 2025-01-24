using System;

namespace ExpenseTracker.Components.model
{
    public class Income
    {
        public int Id { get; set; }
        public int UserId { get; set; } // Ensure incomes belong to a specific user
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string? Source { get; set; }
        public string? Note { get; set; }

        public string Currency { get; set; } = "NPR";
    }
}
