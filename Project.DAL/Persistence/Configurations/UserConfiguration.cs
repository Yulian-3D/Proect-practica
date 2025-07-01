using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(m => m.Name).HasMaxLength(60).IsRequired();

            builder.Property(m => m.Count).IsRequired();

            builder.HasMany(mg => mg.UserItems)
                .WithOne(g => g.User)
                .HasForeignKey(mg => mg.UserId);

            builder.HasMany(mg => mg.BuyItemTrades)
                .WithOne(g => g.BuyerUser)
                .HasForeignKey(mg => mg.BuyerUserId);

            builder.HasMany(mg => mg.SellItemTrades)
                .WithOne(g => g.SellerUser)
                .HasForeignKey(mg => mg.SellerUserId);
        }
    }
}
