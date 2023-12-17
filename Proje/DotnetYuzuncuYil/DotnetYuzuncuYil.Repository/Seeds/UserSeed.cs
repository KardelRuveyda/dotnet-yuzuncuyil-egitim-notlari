using DotnetYuzuncuYil.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Repository.Seeds
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User { Id = 1, Email = "busegizemsezer@gmail.com", Password = "123456", UserName = "busegizem", TeamId = 1, CreatedDate = DateTime.Now },
                new User { Id = 2, Email = "elnurakkurt@gmail.com", Password = "122332", UserName = "elnurak", TeamId = 2, CreatedDate = DateTime.Now },
                new User { Id = 3, Email = "seherselintosun@gmail.com", Password = "42342342", UserName = "seherselin", TeamId = 3, CreatedDate = DateTime.Now },
                new User { Id = 4, Email = "gizemturan@gmail.com", Password = "35345345", UserName = "gizemturan", TeamId = 4, CreatedDate = DateTime.Now }
                );
        }
    }
}
