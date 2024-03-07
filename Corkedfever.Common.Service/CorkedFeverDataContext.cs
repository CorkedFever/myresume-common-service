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
        public DbSet<Messages> Message { get; set; }
        public DbSet<Emails> Email { get; set; }
        public DbSet<JobType> JobType { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbContextAttribute Context { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Messages>().ToTable("Messages");
            modelBuilder.Entity<Emails>().ToTable("Emails");
            modelBuilder.Entity<JobType>().ToTable("JobTypes");
            modelBuilder.Entity<Skill>().ToTable("Skills");
            modelBuilder.Entity<Job>().ToTable("Jobs");
        }
    }
}
