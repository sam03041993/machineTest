using Microsoft.EntityFrameworkCore;

namespace DotNetMachineTest.Models.context
{
    public class MachineTestContext : DbContext
    {
        public MachineTestContext(DbContextOptions<MachineTestContext> options) : base(options) { }

        public DbSet<Unit> Unit { get; set; }

        public DbSet<ConversionRate> ConversionRate { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Unit>().HasData(
                new Unit { Id = 1, Name = "Celsius" },
                new Unit { Id = 2, Name = "Fahrenheit" },
                new Unit { Id = 3, Name = "Meter" },
                new Unit { Id = 4, Name = "Feet" }
                );

            modelBuilder.Entity<ConversionRate>().HasData(
               new ConversionRate
               {
                   Id = 1,
                   FromUnitId = 1,
                   ToUnitId = 2,
                   Rate = 1.8
               },
               new ConversionRate
               {
                   Id = 2,
                   FromUnitId = 2,
                   ToUnitId = 1,
                   Rate = 0.55556
               },
                new ConversionRate
                {
                    Id = 3,
                    FromUnitId = 3,
                    ToUnitId = 4,
                    Rate = 3.28084
                },
                new ConversionRate
                {
                    Id = 4,
                    FromUnitId = 4,
                    ToUnitId = 5,
                    Rate = 0.304
                }
               );
        }
    }
}