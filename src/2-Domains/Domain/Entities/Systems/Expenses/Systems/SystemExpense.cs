namespace Domain.Entities.Systems.Expenses.Systems
{
    public class SystemExpense : Base
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public int MonthlyBookClose { get; set; }
        public bool GenerateExpensesCopy { get; set; }
        public int MonthCopy { get; set; }
        public int YearCopy { get; set; }
    }
}
