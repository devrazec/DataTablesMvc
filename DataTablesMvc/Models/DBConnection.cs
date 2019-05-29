using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataTablesMvc.Models
{
    public class DBConnection : DbContext
    {
        public DBConnection() : base("name=DBStringEf")
        {
        }

        public virtual DbSet<Customers> Customers { get; set; }
        //public virtual DbSet<Categories> Categories { get; set; }
        //public virtual DbSet<Countries> Countries { get; set; }
        //public virtual DbSet<Products> Products { get; set; }
        //public virtual DbSet<Shippers> Shippers { get; set; }
        //public virtual DbSet<Orders> Orders { get; set; }
        //public virtual DbSet<OrderDetails> OrderDetails { get; set; }
    }
}