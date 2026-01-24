using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Emplyee.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "testprop",
                table: "Emplyees");

            migrationBuilder.AddColumn<string>(
                name: "ID_adherent",
                table: "Emplyees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "affiliateName",
                table: "Emplyees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "affiliateNumber",
                table: "Emplyees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cin",
                table: "Emplyees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "creationDate",
                table: "Emplyees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "demandMode",
                table: "Emplyees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "demandState",
                table: "Emplyees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "firstName",
                table: "Emplyees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "immatriculationNumber",
                table: "Emplyees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lastName",
                table: "Emplyees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "newImmatriculatedId",
                table: "Emplyees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "passportNumber",
                table: "Emplyees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "residenceNumber",
                table: "Emplyees",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ID_adherent",
                table: "Emplyees");

            migrationBuilder.DropColumn(
                name: "affiliateName",
                table: "Emplyees");

            migrationBuilder.DropColumn(
                name: "affiliateNumber",
                table: "Emplyees");

            migrationBuilder.DropColumn(
                name: "cin",
                table: "Emplyees");

            migrationBuilder.DropColumn(
                name: "creationDate",
                table: "Emplyees");

            migrationBuilder.DropColumn(
                name: "demandMode",
                table: "Emplyees");

            migrationBuilder.DropColumn(
                name: "demandState",
                table: "Emplyees");

            migrationBuilder.DropColumn(
                name: "firstName",
                table: "Emplyees");

            migrationBuilder.DropColumn(
                name: "immatriculationNumber",
                table: "Emplyees");

            migrationBuilder.DropColumn(
                name: "lastName",
                table: "Emplyees");

            migrationBuilder.DropColumn(
                name: "newImmatriculatedId",
                table: "Emplyees");

            migrationBuilder.DropColumn(
                name: "passportNumber",
                table: "Emplyees");

            migrationBuilder.DropColumn(
                name: "residenceNumber",
                table: "Emplyees");

            migrationBuilder.AddColumn<string>(
                name: "testprop",
                table: "Emplyees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
