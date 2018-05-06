using Pratice.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice.DataLayer
{
    public class PaticeContext : DbContext
    {
        public PaticeContext() : base("DefaultConnection")
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}