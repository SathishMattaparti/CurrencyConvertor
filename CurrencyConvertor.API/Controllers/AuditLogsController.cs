using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CurrencyConvertor.Repository;
using CurrencyConvertor.Repository.Models;

namespace CurrencyConvertor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditLogsController : ControllerBase
    {
        private readonly ExchangeRatesDBContext _context;

        public AuditLogsController(ExchangeRatesDBContext context)
        {
            _context = context;
        }

        // GET: api/AuditLogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AuditLog>>> GetAuditLogs()
        {
            return await _context.AuditLogs.ToListAsync();
        }

        // GET: api/AuditLogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AuditLog>> GetAuditLog(int id)
        {
            var auditLog = await _context.AuditLogs.FindAsync(id);

            if (auditLog == null)
            {
                return NotFound();
            }

            return auditLog;
        }

        [HttpGet("{fromDate}/{toDate}")]
        public async Task<ActionResult<IEnumerable<AuditLog>>> GetAuditLog(long fromDate, long toDate)
        {            
            var fromDt = new DateTime(fromDate);
            var toDt = new DateTime(toDate);

            //Get audit logs between from date and to date
            var auditLog = await _context.AuditLogs.Where(x => x.CreatedOn >= fromDt && x.CreatedOn <= toDt).ToListAsync();

            if (auditLog == null)
            {
                return NotFound();
            }

            return auditLog;
        }

        //// PUT: api/AuditLogs/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutAuditLog(int id, AuditLog auditLog)
        //{
        //    if (id != auditLog.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(auditLog).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AuditLogExists(id))
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

        //// POST: api/AuditLogs
        //[HttpPost]
        //public async Task<ActionResult<AuditLog>> PostAuditLog(AuditLog auditLog)
        //{
        //    _context.AuditLogs.Add(auditLog);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetAuditLog", new { id = auditLog.Id }, auditLog);
        //}

        //// DELETE: api/AuditLogs/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<AuditLog>> DeleteAuditLog(int id)
        //{
        //    var auditLog = await _context.AuditLogs.FindAsync(id);
        //    if (auditLog == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.AuditLogs.Remove(auditLog);
        //    await _context.SaveChangesAsync();

        //    return auditLog;
        //}

        //private bool AuditLogExists(int id)
        //{
        //    return _context.AuditLogs.Any(e => e.Id == id);
        //}
    }
}
