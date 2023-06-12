using Domain.Entities.Systems.Categories;
using Domain.Enums.Types.Systems;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Systems.Expenses
{
    public class Expense : Base
    {
        public decimal Value { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public TransactionType TransactionType { get; set; }
        public DateTime ExpensesRegister { get; set; }
        public DateTime ExpenseUpdate { get; set; }
        public DateTime PayDate { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsPayedExpense { get; set; }
        public bool IsOverDueExpense { get; set; }

        //ForeignKey
        [ForeignKey("Category")]
        [Column(Order = 1)]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
