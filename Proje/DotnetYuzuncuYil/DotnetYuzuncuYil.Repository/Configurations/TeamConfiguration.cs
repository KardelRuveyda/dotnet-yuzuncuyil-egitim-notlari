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
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            //Fluent API ayarlamaları

            //Primary Key ayarlaması
            builder.HasKey(x => x.Id);

            //Primary Key Otomatik olarak 1'er 1'er artsın.
            builder.Property(t => t.Id)
                .UseIdentityColumn();

            //TeamName alanı için maksimum uzunluu belirleme ve bu alanı zorunlu hale getirme
            builder.Property(t => t.TeamName)
                .HasMaxLength(50)
                .IsRequired();

            //Tablo ismini belirleme ( Opsiyon) 
            builder.ToTable("Teams");
        }
    }
}
