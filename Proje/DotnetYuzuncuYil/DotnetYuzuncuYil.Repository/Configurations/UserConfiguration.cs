using DotnetYuzuncuYil.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Repository.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //Primary Key
            builder.HasKey(x => x.Id);

            //1-1 artması 
            builder.Property(x => x.Id)
                .UseIdentityColumn();

            builder.Property(x => x.UserName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(250);

            //Tablo ismi için
            builder.ToTable("Users");
        }
    }
}
