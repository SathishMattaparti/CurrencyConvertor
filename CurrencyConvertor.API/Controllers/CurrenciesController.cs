﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CurrencyConvertor.Repository;

namespace CurrencyConvertor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrenciesController : ControllerBase
    {
        private readonly ExchangeRatesDBContext _context;

        public CurrenciesController(ExchangeRatesDBContext context)
        {
            _context = context;
        }

        // GET: api/Currencies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Currency>>> GetCurrencies()
        {
            return await _context.Currencies.ToListAsync();
        }

       
        //// GET: api/Currencies/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Currency>> GetCurrency(int id)
        //{
        //    var currency = await _context.Currencies.FindAsync(id);

        //    if (currency == null)
        //    {
        //        return NotFound();
        //    }

        //    return currency;
        //}

        //// PUT: api/Currencies/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutCurrency(int id, Currency currency)
        //{
        //    if (id != currency.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(currency).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CurrencyExists(id))
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

        //// POST: api/Currencies
        //[HttpPost]
        //public async Task<ActionResult<Currency>> PostCurrency(Currency currency)
        //{
        //    _context.Currencies.Add(currency);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetCurrency", new { id = currency.Id }, currency);
        //}

        //// DELETE: api/Currencies/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Currency>> DeleteCurrency(int id)
        //{
        //    var currency = await _context.Currencies.FindAsync(id);
        //    if (currency == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Currencies.Remove(currency);
        //    await _context.SaveChangesAsync();

        //    return currency;
        //}

        //private bool CurrencyExists(int id)
        //{
        //    return _context.Currencies.Any(e => e.Id == id);
        //}
    }
}
