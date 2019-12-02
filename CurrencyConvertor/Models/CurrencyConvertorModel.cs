using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConvertor.Models
{
    public class CurrencyConvertorModel
    {
        public IEnumerable<CurrencyCodes> FromCurrencyCodes { get; set; }
        public IEnumerable<CurrencyCodes> ToCurrencyCodes { get; set; }
        public float ExchangeRate { get; set; }
        public float ValueToConvert { get; set; }
        public float ConvertedValue { get; set; }
        public DateTime Date { get; set; }
        public int FromCurrencyCode { get; set;}
        public int ToCurrencyCode { get; set; }


    }
}
