using System;

namespace ExpenseTracker.Components.model
{
    public class Debt
    {
        public int Id { get; set; }
        public int UserId { get; set; } // Ensure debts belong to a specific user
        public decimal Amount { get; set; }
        public decimal PaidAmount { get; set; }
        public DateTime Date { get; set; }
        public string? Note { get; set; }

        public DateTime DueDate { get; set; }
        public string Currency { get; set; } = "NPR";
    }
}
