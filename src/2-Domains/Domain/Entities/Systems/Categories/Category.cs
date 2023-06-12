using Domain.Entities.Systems.Expenses.Systems;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Systems.Categories
{
    public class Category
    {
        [ForeignKey("SystemsExpense")]
        [Column(Order = 1)]
        public int SystemId { get; set; }

        public SystemExpense SystemsExpense { get; set; }
    }
}
