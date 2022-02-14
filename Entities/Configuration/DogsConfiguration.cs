using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    class DogsConfiguration : IEntityTypeConfiguration<Dog>
    {
        public void Configure(EntityTypeBuilder<Dog> builder)
        {
            builder.HasData
            (
                new Dog
                {
                    Id = Guid.NewGuid(),
                    Name = "Neo",
                    Color = "red & amber",
                    Tail_Length = 22,
                    Weight = 32,
                },
                new Dog
                {
                    Id = Guid.NewGuid(),
                    Name = "Jessy",
                    Color = "black & white",
                    Tail_Length = 7,
                    Weight = 14,
                }
            ) ;
        }
    }
}
