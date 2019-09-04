using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockFast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockFast.Repository.Config
{
    public class UserProfileConfiguration : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.HasKey(b => b.ProfileId);
            builder.HasKey(a => a.UserId);


        }
    }
}
