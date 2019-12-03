using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CurrencyConvertor.Repository
{
    /// <summary>
    /// Currency model class to hold different types of currencies 
    /// </summary>
    public class Currency
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CurrencyName { get; set; }
        [Required]
        public string CurrencyCode { get; set; }      
        

    }
}
