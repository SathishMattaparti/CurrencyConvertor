using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurrencyConvertor.Repository;
using CurrencyConvertor.Repository.Models;

namespace CurrencyConvertor.API.Util
{
    public class Logger : ILogger
    {
        private readonly ExchangeRatesDBContext _context;

        public Logger(ExchangeRatesDBContext context)
        {
            _context = context;
        }

        public void Log(AuditLog log)
        {
            _context.AuditLogs.Add(log);
            _context.SaveChangesAsync();
        }
    }
}
