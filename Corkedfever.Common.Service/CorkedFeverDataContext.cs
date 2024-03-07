using Corkedfever.Common.Data.DBModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Corkedfever.Common.Data
{
    public class CorkedFeverDataContext : DbContext
    {

        public CorkedFeverDataContext(DbContextOptions<CorkedFeverDataContext> options) : base(options)
        {

        }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<Emails> Emails { get; set; }
        public DbContextAttribute Context { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Messages>().ToTable("Messages");
            modelBuilder.Entity<Emails>().ToTable("Emails");
        }
    }
}
