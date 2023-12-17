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
    public class UserProfileSeed : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.HasData(
                new UserProfile { Id = 1, FirstName = "Buse", LastName = "Sezer", NickName = "bus", UserId = 1},
                new UserProfile { Id = 2, FirstName = "Elnur", LastName = "Akkurt", NickName = "eln", UserId = 2},
                new UserProfile { Id = 3, FirstName = "Seher", LastName = "Tosun", NickName = "b12", UserId = 3},
                new UserProfile { Id = 4, FirstName = "Gizem", LastName = "Turan", NickName = "sherlock", UserId = 4}
                );
        }
    }
}
