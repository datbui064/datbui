using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;


namespace QLB.Models
{
    public partial class dbQLBContext : DbContext
    {
        public dbQLBContext()
        {
        }

        public dbQLBContext(DbContextOptions<dbQLBContext> options)
            : base(options)
        {
        }

        //Thu thập thông tin làm phần mềm
        public virtual DbSet<tbBaiGiang> tbCongViecs { get; set; }
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
            modelBuilder.Entity<tbBaiGiang>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}