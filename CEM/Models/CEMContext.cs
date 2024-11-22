using System;
using Microsoft.EntityFrameworkCore;
using CEM.Models;

namespace CEM.Models
{
    public partial class CEMContext : DbContext
    {
        

        public CEMContext(DbContextOptions<CEMContext> options)
            : base(options)
        {
        }

        //Thu thập thông tin làm phần mềm
        public virtual DbSet<User> Users { get; set; }
        // Unable to generate entity type for table 'dbo.Docs' since its primary key could not be scaffolded. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();

                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DBConnection"), p => p.EnableRetryOnFailure());

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
