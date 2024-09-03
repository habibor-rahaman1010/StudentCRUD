using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class userRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30df4064-0f22-4ff8-a670-da0517251290");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66accc43-5d9a-4ad4-bc87-e5ff16da2bdd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b406b8c2-fc2e-4f00-bb59-3ae73b6dea80");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "30df4064-0f22-4ff8-a670-da0517251290", "ddd5df61-3b69-4187-adee-0a10253d9684", "USER", "USER" },
                    { "66accc43-5d9a-4ad4-bc87-e5ff16da2bdd", "0bc8392e-94a3-49b4-9287-a534a8f3791f", "SUPERADMIN", "SUPERADMIN" },
                    { "b406b8c2-fc2e-4f00-bb59-3ae73b6dea80", "5047b302-f255-4c45-926c-25f59a2fce9a", "ADMIN", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3423), new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3423) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3425), new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3427), new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3429), new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3430), new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3432), new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3432) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3433), new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3435), new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3437), new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3437) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3438), new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3441), new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3443), new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3444), new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3446), new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3448), new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModificationDate" },
                values: new object[] { new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3449), new DateTime(2024, 9, 2, 23, 50, 31, 785, DateTimeKind.Local).AddTicks(3449) });
        }
    }
}
