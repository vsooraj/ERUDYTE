
using Erudyte.CMS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Erudyte.CMS.Data
{
    public class ErudyteContext : DbContext
    {
        public ErudyteContext(DbContextOptions<ErudyteContext> options) : base(options)

        {

        }

        public DbSet<CategoryType> CategoryTypes { get; set; }




        protected override void OnModelCreating(ModelBuilder builder)

        {

            builder.Entity<CategoryType>(ConfigureCategoryType);

        }


        private void ConfigureCategoryType(EntityTypeBuilder<CategoryType> builder)

        {

            builder.ToTable("CategoryType");


            builder.HasKey(ci => ci.Id);


            builder.Property(cb => cb.Type)

                .IsRequired()

                .HasMaxLength(100);

        }
    }
}
