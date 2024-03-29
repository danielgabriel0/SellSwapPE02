﻿using Microsoft.AspNetCore.Hosting.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SellSwap.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellSwap.Server.Configurations.Entities
{
    public class ListingStatusSeedConfiguration : IEntityTypeConfiguration<ListingStatus>
    {
        public void Configure(EntityTypeBuilder<ListingStatus> builder)
        {
            builder.HasData(
                new ListingStatus
                {
                    Id = 1,
                    Name = "Avaliable",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                },

                new ListingStatus
                {
                    Id = 2,
                    Name = "Sold",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System"
                }

                );

        }
    }
}
