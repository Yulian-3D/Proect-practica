using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Persistence.Configurations
{
    public class UserItemConfiguration : IEntityTypeConfiguration<UserItem>
    {
        public void Configure(EntityTypeBuilder<UserItem> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.HasOne(mg => mg.User)
                .WithMany(g => g.UserItems)
                .HasForeignKey(mg => mg.UserId);

            builder.HasOne(mg => mg.Item)
                .WithMany(g => g.UserItems)
                .HasForeignKey(mg => mg.ItemId);
        }
    }
}
