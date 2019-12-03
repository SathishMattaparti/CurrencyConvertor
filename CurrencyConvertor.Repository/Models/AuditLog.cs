using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CurrencyConvertor.Repository.Models
{
    public class AuditLog
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedOn { get; set; }
        public float Amount { get; set; }
        public int FromCurrencyId { get; set; } //To-do : Need to create foreign key reference to Currency table
        public int ToCurrencyId { get; set; } //To-do : Need to create foreign key reference to Currency table
    }
}
