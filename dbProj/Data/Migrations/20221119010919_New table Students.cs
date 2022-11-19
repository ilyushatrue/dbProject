using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dbProj.Data.Migrations
{
    public partial class NewtableStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "data");

            migrationBuilder.CreateTable(
                name: "Students",
                schema: "data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "data",
                table: "Students",
                columns: new[] { "Id", "BirthDate", "Gender", "Name" },
                values: new object[] { 1, new DateTime(2002, 11, 19, 11, 9, 19, 421, DateTimeKind.Local).AddTicks(2069), false, "First" });

            //migrationBuilder.Sql(@"");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students",
                schema: "data");
        }
    }
}
