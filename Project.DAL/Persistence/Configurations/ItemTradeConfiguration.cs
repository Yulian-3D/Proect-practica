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
    public class ItemTradeConfiguration : IEntityTypeConfiguration<ItemTrade>
    {
        public void Configure(EntityTypeBuilder<ItemTrade> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(m => m.Price).IsRequired();

            builder.Property(m => m.TradeCreateDate).IsRequired();

            builder.Property(m => m.TradeConfirmationDate).IsRequired(false);

            builder.Property(m => m.IsConfirmed).IsRequired();

            builder.HasOne(mg => mg.BuyerUser)
                .WithMany(g => g.BuyItemTrades)
                .HasForeignKey(mg => mg.BuyerUserId);

            builder.HasOne(mg => mg.SellerUser)
                .WithMany(g => g.SellItemTrades)
                .HasForeignKey(mg => mg.SellerUserId);

            builder.HasOne(mg => mg.UserItem)
                .WithMany(g => g.ItemTrades)
                .HasForeignKey(mg => mg.UserItemId);
        }
    }
}
