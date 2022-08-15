using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace iMessengerCoreAPI.Migrations
{
    public partial class RGDialogsClients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RGDialogsClients",
                columns: table => new
                {
                    IDUnique = table.Column<Guid>(type: "uuid", nullable: false),
                    IDRGDialog = table.Column<Guid>(type: "uuid", nullable: false),
                    IDClient = table.Column<Guid>(type: "uuid", nullable: false),
                    DateEvent = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RGDialogsClients", x => x.IDUnique);
                });

            migrationBuilder.InsertData(
                table: "RGDialogsClients",
                columns: new[] { "IDUnique", "DateEvent", "IDClient", "IDRGDialog" },
                values: new object[,]
                {
                    { new Guid("72259fe7-706f-46f8-ab30-3e1add376728"), null, new Guid("4b6a6b9a-2303-402a-9970-6e71f4a47151"), new Guid("fcd6b112-1834-4420-bee6-70c9776f6378") },
                    { new Guid("5dc37876-95b9-4d38-8848-da70aa14ba5b"), null, new Guid("c72e5cb5-d6b4-4c0c-9992-d7ae1c53a820"), new Guid("fcd6b112-1834-4420-bee6-70c9776f6378") },
                    { new Guid("c303d20e-17fb-4a4c-9346-13e49e954563"), null, new Guid("7de3299b-2796-4982-a85b-2d6d1326396e"), new Guid("fcd6b112-1834-4420-bee6-70c9776f6378") },
                    { new Guid("7e61d6b7-3f2d-471b-bd62-b049dd27f8c6"), null, new Guid("4b6a6b9a-2303-402a-9970-6e71f4a47151"), new Guid("19f6f751-7f8d-41fa-8261-709028650592") },
                    { new Guid("a4612660-2a7a-4b2f-99c0-2924dac8f3ab"), null, new Guid("c72e5cb5-d6b4-4c0c-9992-d7ae1c53a820"), new Guid("19f6f751-7f8d-41fa-8261-709028650592") },
                    { new Guid("f16a0c0e-406a-47e0-b6fa-f8c57857e77b"), null, new Guid("7de3299b-2796-4982-a85b-2d6d1326396e"), new Guid("83ebeb2b-c315-48a2-b6e5-f0324de57a9f") },
                    { new Guid("ed8fc5c2-a5fe-4ba1-8ec5-78ae646c7ea4"), null, new Guid("0a58955e-342f-4095-88c6-1109d0f70583"), new Guid("83ebeb2b-c315-48a2-b6e5-f0324de57a9f") },
                    { new Guid("8d28a0ce-27ab-4973-9726-f27b0560b8e9"), null, new Guid("50454d55-a73c-4cbc-be25-3c5729dcb82b"), new Guid("83ebeb2b-c315-48a2-b6e5-f0324de57a9f") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RGDialogsClients");
        }
    }
}
