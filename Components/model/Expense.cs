using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Components.model
{
    public class Expense
    {
        public int Id { get; set; }
        public int UserId { get; set; } // Link to the user who owns this outflow
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string? Tag { get; set; } // Customizable tag for categorization
        public string? Note { get; set; }

        
    }
}
