using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CurrencyConvertor.Models;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using CurrencyConvertor.Repository;
using CurrencyConvertor.Repository.Models;

namespace CurrencyConvertor.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration configuration;
        
        public HomeController(IConfiguration configuration )
        {
            this.configuration = configuration;
        }
        public IActionResult Index()
        {            
            CurrencyConvertorModel model = new CurrencyConvertorModel();
            var data = GetCurrencyCodeList();

            model.FromCurrencyCodes = data;
            model.ToCurrencyCodes = data;
            
            return View(model);
        }

        public IActionResult Logs()
        {
            var logs = new Logs();
            return View(logs);
        }

        [HttpPost]
        public IActionResult Logs(DateTime fromDate, DateTime toDate)
        {
            var logs = new Logs();
            var fromDateInTicks = fromDate.Ticks;
            var toDateInTicks = toDate.Ticks;
            
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(configuration.GetSection("appSettings").GetSection("ApiBaseUrl").Value);

                    var resAuditLogs = client.GetAsync(string.Format("{0}/auditlogs/{1}/{2}", client.BaseAddress, fromDateInTicks, toDateInTicks) );

                    resAuditLogs.Wait();

                    var result = resAuditLogs.Result;

                    if (result.IsSuccessStatusCode)
                    {
                        var readData = result.Content.ReadAsAsync<IList<AuditLog>>();
                        logs.AuditLogs = readData.Result;
                        logs.FromDate = fromDate;
                        logs.ToDate = toDate;
                        return View(logs);
                    }
                    return View(logs);
                }
            }
            catch (Exception ex)
            {
                return View(logs);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Convert(CurrencyConvertorModel obj)
        {
            using (var client = new HttpClient())
            {
                var exchangeRate = 0f;
                client.BaseAddress = new Uri(configuration.GetSection("appSettings").GetSection("ApiBaseUrl").Value);

                long dateInTicks = obj.Date.Ticks;

                var resExchangeRate = client.GetAsync(string.Format("{0}/exchangerates/{1}/{2}/{3}/{4}", client.BaseAddress, dateInTicks, obj.FromCurrencyCode, obj.ToCurrencyCode, obj.ValueToConvert));
                resExchangeRate.Wait();

                obj.FromCurrencyCodes = obj.ToCurrencyCodes = GetCurrencyCodeList();
                 
                var result = resExchangeRate.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readData = result.Content.ReadAsAsync<ExchangeRate>();
                    exchangeRate = readData.Result.Rate;
                    obj.ConvertedValue = obj.ValueToConvert * exchangeRate;
                }
            }

                return View("Index", obj);
        }

        private IList<CurrencyCodes> GetCurrencyCodeList()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(configuration.GetSection("appSettings").GetSection("ApiBaseUrl").Value);

                    var resCurrencyCodes = client.GetAsync(client.BaseAddress + "/currencies");

                    resCurrencyCodes.Wait();

                    var result = resCurrencyCodes.Result;

                    if (result.IsSuccessStatusCode)
                    {
                        var readData = result.Content.ReadAsAsync<IList<CurrencyCodes>>();
                        return readData.Result;
                    }
                    return new List<CurrencyCodes>();
                }
            }
            catch(Exception ex)
            {
                return new List<CurrencyCodes>();
            }
            
        }
    }
}
