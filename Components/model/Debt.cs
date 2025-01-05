using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Components.model
{
    public class Debt
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }

        public decimal PaidAmount { get; set; }

        public DateTime Date { get; set; }
        public string? Note { get; set; }

    }
}
