using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentCURD.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "CreatedDate", "ModificationDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4583), new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4584), "One" },
                    { 2, new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4586), new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4586), "Two" },
                    { 3, new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4588), new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4588), "Three" },
                    { 4, new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4589), new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4590), "Four" },
                    { 5, new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4591), new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4591), "Five" },
                    { 6, new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4593), new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4593), "Six" },
                    { 7, new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4594), new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4595), "Seven" },
                    { 8, new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4596), new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4596), "Eight" },
                    { 9, new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4598), new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4598), "Nine" },
                    { 10, new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4599), new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4600), "Ten" },
                    { 11, new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4601), new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4601), "Colleage First Year" },
                    { 12, new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4640), new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4640), "Colleg Second Year" },
                    { 13, new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4642), new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4642), "BSc In CSE" },
                    { 14, new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4644), new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4644), "BSc In EEE" },
                    { 15, new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4645), new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4646), "BSc In CS" },
                    { 16, new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4647), new DateTime(2024, 2, 26, 14, 32, 38, 973, DateTimeKind.Local).AddTicks(4647), "BSc In Civil" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                table: "Students",
                column: "ClassId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Classes");
        }
    }
}
