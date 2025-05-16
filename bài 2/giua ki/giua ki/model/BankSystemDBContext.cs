using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace WindowsFormsApp1.Model
{
    internal class BankSystemDBContext: DbContext
    {
        public DbSet<Bank_account> bank_accounts { get; set; }
        public DbSet<Transactions> transactions { get; set; }
        string connectionString = "Data source =B508PC50;Initial Catalog = data01;User ID=sa;Password=12345678";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
