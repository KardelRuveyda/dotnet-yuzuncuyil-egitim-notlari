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
    public class TeamSeed : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasData(
                new Team { Id = 1, TeamName = "Development", CreatedDate = DateTime.Now },
                new Team { Id = 2, TeamName = "Sales", CreatedDate = DateTime.Now },
                new Team { Id = 3, TeamName = "Marketing", CreatedDate = DateTime.Now },
                new Team { Id = 4, TeamName = "HR", CreatedDate = DateTime.Now }
                );
        }
    }
}
