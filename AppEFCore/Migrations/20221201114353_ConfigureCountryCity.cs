using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppEFCore.Migrations
{
    public partial class ConfigureCountryCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "TBL_Country");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "TBL_City");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TBL_Country",
                newName: "KeyId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TBL_City",
                newName: "CityName");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "TBL_City",
                newName: "FKid");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_CountryId",
                table: "TBL_City",
                newName: "IX_TBL_City_FKid");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TBL_Country",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CityName",
                table: "TBL_City",
                type: "varchar(25)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_Country",
                table: "TBL_Country",
                column: "KeyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_City",
                table: "TBL_City",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_City_TBL_Country_FKid",
                table: "TBL_City",
                column: "FKid",
                principalTable: "TBL_Country",
                principalColumn: "KeyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_City_TBL_Country_FKid",
                table: "TBL_City");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_Country",
                table: "TBL_Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_City",
                table: "TBL_City");

            migrationBuilder.RenameTable(
                name: "TBL_Country",
                newName: "Countries");

            migrationBuilder.RenameTable(
                name: "TBL_City",
                newName: "Cities");

            migrationBuilder.RenameColumn(
                name: "KeyId",
                table: "Countries",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CityName",
                table: "Cities",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "FKid",
                table: "Cities",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_TBL_City_FKid",
                table: "Cities",
                newName: "IX_Cities_CountryId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(25)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");
        }
    }
}
