using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Project.DAL.Entities;

namespace Project.DAL.Persistence.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(m => m.Name).HasMaxLength(60).IsRequired();

            builder.Property(m => m.Price).IsRequired();

            builder.Property(m => m.PhotoLink).HasMaxLength(500).IsRequired();

            builder.Property(m => m.Rarity).IsRequired();

            builder.Property(m => m.Description).HasMaxLength(500).IsRequired();

            builder.HasMany(mg => mg.UserItems)
                .WithOne(g => g.Item)
                .HasForeignKey(mg => mg.ItemId);

            builder.HasMany(mg => mg.ItemTrades)
                .WithOne(g => g.Item)
                .HasForeignKey(mg => mg.ItemId);
        }
    }
}
