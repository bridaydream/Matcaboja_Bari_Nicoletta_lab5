using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AutoGeistModel2
{
    public partial class AutoGeistEntitiesModel2 : DbContext
    {
        public AutoGeistEntitiesModel2()
            : base("name=AutoGeistEntitiesModel2")
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
