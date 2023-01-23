﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Sms.Sent.DAL.Models;

namespace Sms_sent.DAL.Migrations
{
    [DbContext(typeof(SmsContext))]
    [Migration("20230123183116_SmsDb")]
    partial class SmsDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Sms.Sent.DAL.Models.SmsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateSend")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("RecepientPhone")
                        .HasColumnType("integer");

                    b.Property<string>("SmsStatus")
                        .HasColumnType("text");

                    b.Property<string>("SmsText")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("SmsDB");
                });
#pragma warning restore 612, 618
        }
    }
}
