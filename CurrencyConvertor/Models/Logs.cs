using CurrencyConvertor.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConvertor.Models
{
    public class Logs
    {
        public Logs()
        {
            AuditLogs = new List<AuditLog>();
        }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public IList<AuditLog> AuditLogs { get; set; }
    }
}
