using Microsoft.EntityFrameworkCore;

namespace TriNimbus_SimpleAPI.Models
{
    public class AccountContext : DbContext
    {
        public AccountContext(DbContextOptions<AccountContext> options)
            : base(options)
        {}

        public DbSet<Account> Accounts { get; set; }
    }

    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}