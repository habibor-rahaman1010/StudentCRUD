using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class editUserTableRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "983deed1-65a4-4a9d-ac53-f09d2b419df7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e172b5f2-22dc-4b6e-909f-3aee39448590");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "110b8bbf-002e-4d12-abdb-09b377339b69", "27076d17-0839-409d-8747-d078050c83ea" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "110b8bbf-002e-4d12-abdb-09b377339b69");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27076d17-0839-409d-8747-d078050c83ea");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "10cb36c2-b256-4654-b46e-5684058292ce", "a780c97d-6fda-4529-889a-637bc3de5f2c", "USER", "USER" },
                    { "4c82f298-5b61-49f2-84d0-0227016cd564", "c066892c-de60-4663-82d9-2dd781aa5c1d", "SUPERADMIN", "SUPERADMIN" },
                    { "85e9290e-853e-4268-bacc-be56ec953bea", "cbe57f42-fb7b-4625-90a5-9b7edd846c58", "ADMIN", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[] { "ba60bf99-146b-4a0b-ada1-46cd35654c61", 0, "", "f909331d-20b2-4eea-bbc6-89076a84ffce", new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(6378), "habibor.rahaman1010@gmail.com", true, "Habibor", "Rahaman", false, null, "HABIBOR.RAHAMAN1010@GMAIL.COM", "HABIBOR.RAHAMAN1010@GMAIL.COM", "AQAAAAEAACcQAAAAEPF3OeeDuEg7O99c2hg3FquDcqDCvsk1DEln0c7UObMKh1qO8HfZt2HMu5JdrGfiDA==", "01768280237", true, "", "726b7f16-e13b-427f-8bbd-77177143539f", false, new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(6390), "habibor.rahaman1010@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7632), new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7634), new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7636), new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7637), new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7640), new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7641), new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7643), new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7645), new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7646), new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7648), new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7648) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7650), new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7651), new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7653), new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7653) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7654), new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7656), new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7656) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7657), new DateTime(2024, 9, 3, 16, 9, 7, 108, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4c82f298-5b61-49f2-84d0-0227016cd564", "ba60bf99-146b-4a0b-ada1-46cd35654c61" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10cb36c2-b256-4654-b46e-5684058292ce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85e9290e-853e-4268-bacc-be56ec953bea");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4c82f298-5b61-49f2-84d0-0227016cd564", "ba60bf99-146b-4a0b-ada1-46cd35654c61" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c82f298-5b61-49f2-84d0-0227016cd564");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba60bf99-146b-4a0b-ada1-46cd35654c61");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "110b8bbf-002e-4d12-abdb-09b377339b69", "5f11b9db-23bf-42f1-9d97-11412a8356d3", "SUPERADMIN", "Super Admin" },
                    { "983deed1-65a4-4a9d-ac53-f09d2b419df7", "7d8bd21b-3ca8-46d8-a9d9-9e332a5275de", "USER", "User" },
                    { "e172b5f2-22dc-4b6e-909f-3aee39448590", "ce4b91ab-385c-4d20-979d-3d6234647daf", "ADMIN", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UpdateAt", "UserName" },
                values: new object[] { "27076d17-0839-409d-8747-d078050c83ea", 0, "", "433d47ad-7d5a-49f2-9f27-2529eeb45660", new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(8406), "habibor.rahaman1010@gmail.com", true, "Habibor", "Rahaman", false, null, "HABIBOR.RAHAMAN1010@GMAIL.COM", "HABIBOR.RAHAMAN1010@GMAIL.COM", "AQAAAAEAACcQAAAAEEsm0XNBgWmWekZRxnWb8irOJooJl9tO8yNhfrTMSaqlWo8w1FQDpArUrL+OGX23Zw==", "01768280237", true, "", "cfdb5bc0-c21a-401e-bdb5-a4786ddf605c", false, new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(8415), "habibor.rahaman1010@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9519), new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9522), new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9552), new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9553), new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9555), new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9557), new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9558), new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9560), new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9561), new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9563), new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9564), new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9566), new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9568), new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9569), new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9571), new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9572), new DateTime(2024, 9, 3, 9, 58, 46, 464, DateTimeKind.Local).AddTicks(9573) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "110b8bbf-002e-4d12-abdb-09b377339b69", "27076d17-0839-409d-8747-d078050c83ea" });
        }
    }
}
