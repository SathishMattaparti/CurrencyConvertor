using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CurrencyConvertor.Repository;
using CurrencyConvertor.Repository.Models;
using System.Threading;
using CurrencyConvertor.API.Util;

namespace CurrencyConvertor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExchangeRatesController : ControllerBase
    {
        private readonly ExchangeRatesDBContext _context;
        private ILogger _logger;
        private AuditLog auditLog;

        public ExchangeRatesController(ExchangeRatesDBContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/ExchangeRates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExchangeRate>>> GetExchangeRates()
        {
            return await _context.ExchangeRates.ToListAsync();
        }

        // GET: api/ExchangeRates/2019-11-20/1/2
        [HttpGet("{id}/{fromCurrencyId}/{toCurrencyId}/{amount}")]
        public async Task<ActionResult<ExchangeRate>> GetExchangeRate(long id, int fromCurrencyId, int toCurrencyId, float amount)
        {
            auditLog = new AuditLog();
            DateTime dt = new DateTime(id);
            auditLog.CreatedOn = DateTime.Now;
            auditLog.FromCurrencyId = fromCurrencyId;
            auditLog.ToCurrencyId = toCurrencyId;
            auditLog.Amount = amount;
            auditLog.UserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            _logger.Log(auditLog);
            
            var exchangeRate = await _context.ExchangeRates.FindAsync(dt, fromCurrencyId, toCurrencyId);

            if (exchangeRate == null)
            {
                return NotFound();
            }

            return exchangeRate;
        }

        //// PUT: api/ExchangeRates/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutExchangeRate(DateTime id, ExchangeRate exchangeRate)
        //{
        //    if (id != exchangeRate.Date)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(exchangeRate).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ExchangeRateExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/ExchangeRates
        //[HttpPost]
        //public async Task<ActionResult<ExchangeRate>> PostExchangeRate(ExchangeRate exchangeRate)
        //{
        //    _context.ExchangeRates.Add(exchangeRate);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (ExchangeRateExists(exchangeRate.Date))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetExchangeRate", new { id = exchangeRate.Date }, exchangeRate);
        //}

        //// DELETE: api/ExchangeRates/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<ExchangeRate>> DeleteExchangeRate(DateTime id)
        //{
        //    var exchangeRate = await _context.ExchangeRates.FindAsync(id);
        //    if (exchangeRate == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.ExchangeRates.Remove(exchangeRate);
        //    await _context.SaveChangesAsync();

        //    return exchangeRate;
        //}

        //private bool ExchangeRateExists(DateTime id)
        //{
        //    return _context.ExchangeRates.Any(e => e.Date == id);
        //}


    }
}
