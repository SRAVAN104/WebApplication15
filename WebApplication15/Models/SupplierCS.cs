using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication15.Models
{
    [Table("Supplier")]
    public class SupplierCS
    {
        [Key]

        public int Supplier_ID { get; set; }
        public string Name { get; set; }
        public string No_phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}