using CurrencyConvertor.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CurrencyConvertor.Repository
{
    public class ExchangeRatesDBContext : DbContext
    {
        public ExchangeRatesDBContext() : base() {

        }
        public ExchangeRatesDBContext(DbContextOptions<ExchangeRatesDBContext> options) : base(options) {

        }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<ExchangeRate> ExchangeRates { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExchangeRate>().HasKey(e => new { e.Date, e.FromCurrencyId, e.ToCurrencyId }); //Composite key defining the rate on given day           
            
        }

    }
}
