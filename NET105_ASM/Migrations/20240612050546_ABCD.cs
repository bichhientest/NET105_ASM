using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NET105_ASM.Migrations
{
    /// <inheritdoc />
    public partial class ABCD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComboId",
                table: "OrderCombos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderCombos_ComboId",
                table: "OrderCombos",
                column: "ComboId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderCombos_Combo_ComboId",
                table: "OrderCombos",
                column: "ComboId",
                principalTable: "Combo",
                principalColumn: "ComboId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderCombos_Combo_ComboId",
                table: "OrderCombos");

            migrationBuilder.DropIndex(
                name: "IX_OrderCombos_ComboId",
                table: "OrderCombos");

            migrationBuilder.DropColumn(
                name: "ComboId",
                table: "OrderCombos");
        }
    }
}
