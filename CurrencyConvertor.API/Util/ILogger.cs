using CurrencyConvertor.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConvertor.API.Util
{
    public interface ILogger
    {
        void Log(AuditLog log);
    }
}
