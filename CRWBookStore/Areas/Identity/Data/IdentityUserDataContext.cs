using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRWBookStore.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRWBookStore.Areas.Identity.Data
{
    public class IdentityUserDataContext : IdentityDbContext<CRWBookStoreUser>
    {
        public IdentityUserDataContext(DbContextOptions<IdentityUserDataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
        }
    }

    internal class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<CRWBookStoreUser>
    {

        public void Configure(EntityTypeBuilder<CRWBookStoreUser> builder)

        {

            builder.Property(u => u.FirstName).HasMaxLength(225);
            builder.Property(u => u.LastName).HasMaxLength(225);
            builder.Property(u => u.AddressLine1).HasMaxLength(225);
            builder.Property(u => u.AddressLine2).HasMaxLength(225);
            builder.Property(u => u.City).HasMaxLength(225);
            builder.Property(u => u.State).HasMaxLength(225);
            builder.Property(u => u.ZipCode).HasMaxLength(225);


        }

    }
}

