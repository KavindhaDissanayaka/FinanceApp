using FinanceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Data
{
    public class FinanceDataContext : DbContext
    {
        public FinanceDataContext(DbContextOptions<FinanceDataContext> options) : base(options)
        {
        }
        public DbSet<Expense> Expenses { get; set; }

    }
}
