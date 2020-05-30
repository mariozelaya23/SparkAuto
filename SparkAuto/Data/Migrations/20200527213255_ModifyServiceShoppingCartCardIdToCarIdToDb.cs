using Microsoft.EntityFrameworkCore.Migrations;

namespace SparkAuto.Data.Migrations
{
    public partial class ModifyServiceShoppingCartCardIdToCarIdToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceShoppingCart_Car_CarId",
                table: "ServiceShoppingCart");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "ServiceShoppingCart");

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "ServiceShoppingCart",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceShoppingCart_Car_CarId",
                table: "ServiceShoppingCart",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceShoppingCart_Car_CarId",
                table: "ServiceShoppingCart");

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "ServiceShoppingCart",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CardId",
                table: "ServiceShoppingCart",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceShoppingCart_Car_CarId",
                table: "ServiceShoppingCart",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
