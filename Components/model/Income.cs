using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Components.model
{
    public class Income
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }
        public string? Source { get; set; }

        public string? Note { get; set; }

       


    }
}
