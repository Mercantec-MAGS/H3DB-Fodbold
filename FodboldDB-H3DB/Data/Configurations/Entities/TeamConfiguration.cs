using Domain;
using FodboldDB_H3DB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configurations.Entities
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(50);
            builder.HasIndex(h => h.Name).IsUnique();

            builder.HasData(
                new Team
                {
                    Id = 20,
                    Name = "Team 1"
                },
                new Team
                {
                    Id = 21,
                    Name = "Team 2"
                },
                new Team
                {
                    Id = 22,
                    Name = "Team 3"
                }
            );
        }
    }
}
