using BusinessLayer ;
 
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiOrders.Models;

namespace BusinessLayer
{
    public partial class dbContextNW :  DbContext
    {
        

        public dbContextNW(DbContextOptions<dbContextNW> options) : base(options)
        {

        }


        public DbSet<Product> Product { get; set; }
       
        public DbSet<Categorie> Categorie { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Order> Order { get; set; }
        
        public DbSet<Shipper> Shipper { get; set; }

    }
}