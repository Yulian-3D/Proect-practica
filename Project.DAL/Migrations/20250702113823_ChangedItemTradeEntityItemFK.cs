using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ChangedItemTradeEntityItemFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemTrades_Items_ItemId",
                table: "ItemTrades");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "ItemTrades",
                newName: "UserItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemTrades_ItemId",
                table: "ItemTrades",
                newName: "IX_ItemTrades_UserItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemTrades_UserItems_UserItemId",
                table: "ItemTrades",
                column: "UserItemId",
                principalTable: "UserItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemTrades_UserItems_UserItemId",
                table: "ItemTrades");

            migrationBuilder.RenameColumn(
                name: "UserItemId",
                table: "ItemTrades",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemTrades_UserItemId",
                table: "ItemTrades",
                newName: "IX_ItemTrades_ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemTrades_Items_ItemId",
                table: "ItemTrades",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
