using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DataTablesMvc.Models
{
    [Table("Customers")]
    public class Customers
    {
        [Key]
        public int CustomerID { get; set; }
        public int CountryID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}