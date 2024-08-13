using Microsoft.EntityFrameworkCore;
using PerformancePrototypeV1.API.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformancePrototypeV1.API.DAL
{
    public class InformationDBContext : DbContext
    {
        public InformationDBContext(DbContextOptions<InformationDBContext> options):base(options)
        { }
        public DbSet<TransactionDetail> TransactionDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
