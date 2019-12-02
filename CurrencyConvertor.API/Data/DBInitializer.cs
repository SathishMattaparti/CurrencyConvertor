using CurrencyConvertor.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConvertor.API.Data
{
    public class DBInitializer
    {
        public static void Initialize(ExchangeRatesDBContext context)
        {
            try
            {
                context.Database.EnsureCreated();

                if (context.Currencies.Any())
                {
                    return;
                }

                var britainCurrency = new Currency { CurrencyName = "Sterling Pound", CurrencyCode = "GBP" };
                var australiaCurrency = new Currency { CurrencyName = "Australia Dollar", CurrencyCode = "AUD" };
                var americaCurrency = new Currency { CurrencyName = "USA Dollar", CurrencyCode = "USD" };
                var euroCurrency = new Currency { CurrencyName = "Euro", CurrencyCode = "EUR" };

                var currencies = new Currency[] { britainCurrency, australiaCurrency, americaCurrency, euroCurrency };

                foreach (var currency in currencies)
                {
                    context.Currencies.Add(currency);
                }

                context.SaveChanges();

                if (context.ExchangeRates.Any())
                {
                    return;
                }

                var curFor01DecGBPToAUD = new ExchangeRate { Date = new DateTime(2019, 12, 1), FromCurrencyId = 1, ToCurrencyId = 2, Rate = 1.823f };
                var curFor01DecGBPToUSA = new ExchangeRate { Date = new DateTime(2019, 12, 1), FromCurrencyId = 1, ToCurrencyId = 3, Rate = 1.114f };
                var curFor01DecGBPToEUR = new ExchangeRate { Date = new DateTime(2019, 12, 1), FromCurrencyId = 1, ToCurrencyId = 4, Rate = 1.123f };
                var curFor02DecGBPToAUD = new ExchangeRate { Date = new DateTime(2019, 12, 2), FromCurrencyId = 1, ToCurrencyId = 2, Rate = 1.723f };
                var curFor02DecGBPToUSA = new ExchangeRate { Date = new DateTime(2019, 12, 2), FromCurrencyId = 1, ToCurrencyId = 3, Rate = 1.123f };
                var curFor02DecGBPToEUR = new ExchangeRate { Date = new DateTime(2019, 12, 2), FromCurrencyId = 1, ToCurrencyId = 4, Rate = 1.565f };
                var curFor03DecGBPToAUD = new ExchangeRate { Date = new DateTime(2019, 12, 3), FromCurrencyId = 1, ToCurrencyId = 2, Rate = 1.457f };
                var curFor03DecGBPToUSA = new ExchangeRate { Date = new DateTime(2019, 12, 3), FromCurrencyId = 1, ToCurrencyId = 3, Rate = 1.144f };
                var curFor03DecGBPToEUR = new ExchangeRate { Date = new DateTime(2019, 12, 3), FromCurrencyId = 1, ToCurrencyId = 4, Rate = 1.785f };

                var exchangeRates = new ExchangeRate[] { curFor01DecGBPToAUD, curFor01DecGBPToUSA, curFor01DecGBPToEUR,
                                                        curFor02DecGBPToAUD, curFor02DecGBPToUSA, curFor02DecGBPToEUR,
                                                        curFor03DecGBPToAUD, curFor03DecGBPToUSA, curFor03DecGBPToEUR };

                foreach (var er in exchangeRates)
                {
                    context.ExchangeRates.Add(er);
                }

                context.SaveChanges();

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        
    }
}
