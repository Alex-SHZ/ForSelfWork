// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using iMessengerCoreAPI.Data;

namespace iMessengerCoreAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220815123200_RGDialogsClients")]
    partial class RGDialogsClients
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("iMessengerCoreAPI.Models.RGDialogsClients", b =>
                {
                    b.Property<Guid>("IDUnique")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DateEvent")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("IDClient")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IDRGDialog")
                        .HasColumnType("uuid");

                    b.HasKey("IDUnique");

                    b.ToTable("RGDialogsClients");

                    b.HasData(
                        new
                        {
                            IDUnique = new Guid("72259fe7-706f-46f8-ab30-3e1add376728"),
                            IDClient = new Guid("4b6a6b9a-2303-402a-9970-6e71f4a47151"),
                            IDRGDialog = new Guid("fcd6b112-1834-4420-bee6-70c9776f6378")
                        },
                        new
                        {
                            IDUnique = new Guid("5dc37876-95b9-4d38-8848-da70aa14ba5b"),
                            IDClient = new Guid("c72e5cb5-d6b4-4c0c-9992-d7ae1c53a820"),
                            IDRGDialog = new Guid("fcd6b112-1834-4420-bee6-70c9776f6378")
                        },
                        new
                        {
                            IDUnique = new Guid("c303d20e-17fb-4a4c-9346-13e49e954563"),
                            IDClient = new Guid("7de3299b-2796-4982-a85b-2d6d1326396e"),
                            IDRGDialog = new Guid("fcd6b112-1834-4420-bee6-70c9776f6378")
                        },
                        new
                        {
                            IDUnique = new Guid("7e61d6b7-3f2d-471b-bd62-b049dd27f8c6"),
                            IDClient = new Guid("4b6a6b9a-2303-402a-9970-6e71f4a47151"),
                            IDRGDialog = new Guid("19f6f751-7f8d-41fa-8261-709028650592")
                        },
                        new
                        {
                            IDUnique = new Guid("a4612660-2a7a-4b2f-99c0-2924dac8f3ab"),
                            IDClient = new Guid("c72e5cb5-d6b4-4c0c-9992-d7ae1c53a820"),
                            IDRGDialog = new Guid("19f6f751-7f8d-41fa-8261-709028650592")
                        },
                        new
                        {
                            IDUnique = new Guid("f16a0c0e-406a-47e0-b6fa-f8c57857e77b"),
                            IDClient = new Guid("7de3299b-2796-4982-a85b-2d6d1326396e"),
                            IDRGDialog = new Guid("83ebeb2b-c315-48a2-b6e5-f0324de57a9f")
                        },
                        new
                        {
                            IDUnique = new Guid("ed8fc5c2-a5fe-4ba1-8ec5-78ae646c7ea4"),
                            IDClient = new Guid("0a58955e-342f-4095-88c6-1109d0f70583"),
                            IDRGDialog = new Guid("83ebeb2b-c315-48a2-b6e5-f0324de57a9f")
                        },
                        new
                        {
                            IDUnique = new Guid("8d28a0ce-27ab-4973-9726-f27b0560b8e9"),
                            IDClient = new Guid("50454d55-a73c-4cbc-be25-3c5729dcb82b"),
                            IDRGDialog = new Guid("83ebeb2b-c315-48a2-b6e5-f0324de57a9f")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
