using System.ComponentModel.DataAnnotations;

namespace FinanceApp.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [Required]
        public String Description { get; set; } = null!;
        [Required]
        [Range(0.01,double.MaxValue,ErrorMessage ="Amount Need to be grater than 0")]
        public double Amount { get; set; }
        [Required]
        public string Category { get; set; } = null!;
        public DateTime EntryDate { get; set; }= DateTime.Now;
    }
}
