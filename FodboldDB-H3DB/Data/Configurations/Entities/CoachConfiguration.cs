﻿using Domain;
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
    public class CoachConfiguration : IEntityTypeConfiguration<Coach>
    {
        public void Configure(EntityTypeBuilder<Coach> builder)
        {
            builder.Property(p => p.Name).HasMaxLength(50);
            // Multiple fields index defined by an anonymous type
            builder.HasIndex(h => new { h.Name, h.TeamId }).IsUnique();

            builder.HasData(
                new Coach
                {
                    Id = 20,
                    Name = "Coach1",
                    TeamId = 20
                },
                new Coach
                {
                    Id = 21,
                    Name = "Coach2",
                    TeamId = 21
                },
                new Coach
                {
                    Id = 22,
                    Name = "Coach3",
                    TeamId = 22
                }
            );
        }
    }
}
