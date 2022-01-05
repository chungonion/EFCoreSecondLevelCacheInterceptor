﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Issue12PostgreSql.DataLayer;
using Issue12PostgreSql.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Issue12PostgreSql.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Issue12PostgreSql.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Issue12PostgreSql.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Issue12PostgreSql.Entities.Entity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int[]>("Array")
                        .HasColumnType("integer[]");

                    b.HasKey("Id");

                    b.ToTable("Entities");
                });

            modelBuilder.Entity("Issue12PostgreSql.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AddDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<byte[]>("ByteArrayValue")
                        .HasColumnType("bytea");

                    b.Property<byte>("ByteValue")
                        .HasColumnType("smallint");

                    b.Property<char>("CharValue")
                        .HasColumnType("character(1)");

                    b.Property<DateTime>("DateTimeOffsetValue")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("DecimalValue")
                        .HasColumnType("numeric");

                    b.Property<double>("DoubleValue")
                        .HasColumnType("double precision");

                    b.Property<float>("FloatValue")
                        .HasColumnType("real");

                    b.Property<Guid>("GuidValue")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<List<BlogOption>>("OptionDefinitions")
                        .HasColumnType("jsonb");

                    b.Property<long>("Points")
                        .HasColumnType("bigint");

                    b.Property<short>("ShortValue")
                        .HasColumnType("smallint");

                    b.Property<TimeSpan>("TimeSpanValue")
                        .HasColumnType("interval");

                    b.Property<long>("UintValue")
                        .HasColumnType("bigint");

                    b.Property<decimal>("UlongValue")
                        .HasColumnType("numeric(20,0)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("UshortValue")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("Issue12PostgreSql.Entities.Address", b =>
                {
                    b.HasOne("Issue12PostgreSql.Entities.Person", "Person")
                        .WithMany("Addresses")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Issue12PostgreSql.Entities.Book", b =>
                {
                    b.HasOne("Issue12PostgreSql.Entities.Person", "Person")
                        .WithMany("Books")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Issue12PostgreSql.Entities.Person", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
