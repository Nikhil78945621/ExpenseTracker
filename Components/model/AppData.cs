using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Components.model
{
    public class AppData
    {
        public List<User> Users { get; set; } = new();

        public List<Income> Incomes { get; set; } = new();

        public List<Expense> Expenses { get; set; } = new();
        public List<Debt> Debts { get; set; } = new();

        public decimal CurrentBalance => Incomes.Sum(i => i.Amount) - Expenses.Sum(e => e.Amount);
        public bool HasSufficientBalance(decimal amount) => CurrentBalance >= amount;

    }
}
