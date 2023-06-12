using Domain.Entities.Systems.Expenses.Systems;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Systems.Users
{
    public class SystemUser
    {
        public int Id { get; set; }

        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public bool Administrator { get; set; }
        public bool ActualSytem { get; set; }

        //Foreign Key
        [ForeignKey("SystemExpense")]
        [Column(Order = 1)]
        public int SystemId { get; set; }
        public virtual SystemExpense SystemExpense { get; set; }
    }
}
