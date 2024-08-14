using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymTracker.Backend.Data.Migrations
{
    /// <inheritdoc />
    public partial class MakeWeightJson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdditionalWeight_IsDoubled",
                table: "Record");

            migrationBuilder.DropColumn(
                name: "AdditionalWeight_Unit",
                table: "Record");

            migrationBuilder.DropColumn(
                name: "AdditionalWeight_Value",
                table: "Record");

            migrationBuilder.DropColumn(
                name: "Weight_IsDoubled",
                table: "Record");

            migrationBuilder.DropColumn(
                name: "Weight_Unit",
                table: "Record");

            migrationBuilder.DropColumn(
                name: "Weight_Value",
                table: "Record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Record",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "AdditionalWeight",
                table: "Record",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Weight",
                table: "Record",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdditionalWeight",
                table: "Record");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Record");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Record",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AdditionalWeight_IsDoubled",
                table: "Record",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "AdditionalWeight_Unit",
                table: "Record",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "AdditionalWeight_Value",
                table: "Record",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<bool>(
                name: "Weight_IsDoubled",
                table: "Record",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Weight_Unit",
                table: "Record",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "Weight_Value",
                table: "Record",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
