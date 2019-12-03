using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CurrencyConvertor.Repository
{
    public class ExchangeRate
    {          
        public DateTime Date { get; set; }        
        public int FromCurrencyId { get; set; } //Need to create foreign key reference to Currency table
        public int ToCurrencyId { get; set; } //Need to create foreign key reference to Currency table
        public float Rate { get; set; }        

    }
}
