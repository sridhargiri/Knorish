using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Assessment.BoatModel
{
    public partial class BoatDataContext : DbContext
    {
        public BoatDataContext()
        {
        }

        public BoatDataContext(DbContextOptions<BoatDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BoatCustomerRent> BoatCustomerRent { get; set; }
        public virtual DbSet<BoatDetails> BoatDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
               .AddJsonFile("appsettings.json")
               .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoatCustomerRent>(entity =>
            {
                entity.HasKey(e => e.BoatId)
                    .HasName("PK__BoatCust__1488299C895AC121");

                entity.Property(e => e.BoatId).ValueGeneratedNever();

                entity.Property(e => e.CustomerName).IsUnicode(false);

                entity.HasOne(d => d.Boat)
                    .WithOne(p => p.BoatCustomerRent)
                    .HasForeignKey<BoatCustomerRent>(d => d.BoatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BoatCusto__BoatI__2F10007B");
            });

            modelBuilder.Entity<BoatDetails>(entity =>
            {
                entity.HasKey(e => e.BoatId)
                    .HasName("PK__BoatDeta__1488299C87BD70D6");

                entity.Property(e => e.BoatName).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
