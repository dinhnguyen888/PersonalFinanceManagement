namespace PersonalFinanceManagement.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public CategoryType Type { get; set; }
        public bool IsActive { get; set; } = true;
    }

    public enum CategoryType
    {
        Income,
        Expense
    }
}