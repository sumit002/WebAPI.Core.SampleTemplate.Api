using System;

namespace Expenses.Data.Model
{
    public class Expense : EntityBase
    {
        public DateTime ExpenseDate { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Comment { get; set; }

        public int UserId { get; set; }
        //public virtual User User { get; set; }

        public bool IsDeleted { get; set; }
    }
}
