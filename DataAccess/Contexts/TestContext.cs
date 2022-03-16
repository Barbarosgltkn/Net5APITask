using Core.Entities.Concrete;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts
{
    public class TestContext : DbContext
    {
        public DbSet<Test> Tests { get; set; }       
        public DbSet<User> Users { get; set; }

        public TestContext()
        {

        }

        public TestContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=FIX;Database=TestDB;User=sa;Password=b4rb4r0s;");
            }
        }
    }

   
}
