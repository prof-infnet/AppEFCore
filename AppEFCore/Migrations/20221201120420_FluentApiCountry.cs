using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppEFCore.Migrations
{
    public partial class FluentApiCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Name",
                table: "Countries",
                newName: "CountryName");

            migrationBuilder.RenameColumn(
                name: "KeyId",
                table: "Countries",
                newName: "PId");

            migrationBuilder.RenameColumn(
                name: "CityName",
                table: "Cities",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "FKid",
                table: "Cities",
                newName: "CountryPId");

            migrationBuilder.RenameIndex(
                name: "IX_TBL_City_FKid",
                table: "Cities",
                newName: "IX_Cities_CountryPId");

            migrationBuilder.AlterColumn<string>(
                name: "CountryName",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "USA",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedOn",
                table: "Countries",
                type: "date",
                nullable: false,
                defaultValueSql: "(getdate())");

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
                column: "PId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryPId",
                table: "Cities",
                column: "CountryPId",
                principalTable: "Countries",
                principalColumn: "PId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryPId",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "AddedOn",
                table: "Countries");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "TBL_Country");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "TBL_City");

            migrationBuilder.RenameColumn(
                name: "CountryName",
                table: "TBL_Country",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "PId",
                table: "TBL_Country",
                newName: "KeyId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TBL_City",
                newName: "CityName");

            migrationBuilder.RenameColumn(
                name: "CountryPId",
                table: "TBL_City",
                newName: "FKid");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_CountryPId",
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
                oldDefaultValue: "USA");

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
    }
}
