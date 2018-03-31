using Erudyte.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Erudyte.Infrastructure.Data
{
    public class ErudyteContext : DbContext
    {
        public ErudyteContext(DbContextOptions<ErudyteContext> options) : base(options)

        {

        }

        public DbSet<CatagoryType> CatagoryTypes { get; set; }




        protected override void OnModelCreating(ModelBuilder builder)

        {

            builder.Entity<CatagoryType>(ConfigureCatagoryType);

        }


        private void ConfigureCatagoryType(EntityTypeBuilder<CatagoryType> builder)

        {

            builder.ToTable("CatagoryType");


            builder.HasKey(ci => ci.Id);


            builder.Property(cb => cb.Type)

                .IsRequired()

                .HasMaxLength(100);

        }
    }
}
