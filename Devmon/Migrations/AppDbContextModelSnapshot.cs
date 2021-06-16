﻿// <auto-generated />
using System;
using Devmon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Devmon.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Devmon.Models.ms02", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("controller")
                        .HasColumnType("text");

                    b.Property<string>("ip")
                        .HasColumnType("text")
                        .HasColumnName("ip");

                    b.Property<string>("lokasi")
                        .HasColumnType("text")
                        .HasColumnName("lokasi");

                    b.Property<string>("mac")
                        .HasColumnType("text")
                        .HasColumnName("mac");

                    b.Property<decimal>("sensorsuhu_in")
                        .HasColumnType("numeric")
                        .HasColumnName("sensorsuhu_in");

                    b.Property<decimal>("sensorsuhu_out")
                        .HasColumnType("numeric")
                        .HasColumnName("sensorsuhu_out");

                    b.Property<DateTime>("waktu")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("id");

                    b.ToTable("ms02");
                });

            modelBuilder.Entity("Devmon.Models.ms04", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("ampere_ac")
                        .HasColumnType("numeric")
                        .HasColumnName("ampere_ac");

                    b.Property<decimal>("ampere_dc")
                        .HasColumnType("numeric")
                        .HasColumnName("ampere_dc");

                    b.Property<string>("controller")
                        .HasColumnType("text");

                    b.Property<string>("ip")
                        .HasColumnType("text")
                        .HasColumnName("ip");

                    b.Property<string>("lokasi")
                        .HasColumnType("text")
                        .HasColumnName("lokasi");

                    b.Property<string>("mac")
                        .HasColumnType("text")
                        .HasColumnName("mac");

                    b.Property<decimal>("sensorsuhu_in")
                        .HasColumnType("numeric")
                        .HasColumnName("sensorsuhu_in");

                    b.Property<decimal>("sensorsuhu_out")
                        .HasColumnType("numeric")
                        .HasColumnName("sensorsuhu_out");

                    b.Property<decimal>("voltage_ac")
                        .HasColumnType("numeric")
                        .HasColumnName("voltage_ac");

                    b.Property<decimal>("voltage_dc")
                        .HasColumnType("numeric")
                        .HasColumnName("voltage_dc");

                    b.Property<DateTime>("waktu")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("id");

                    b.ToTable("ms04");
                });

            modelBuilder.Entity("Devmon.Models.ms06", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("ampere_ac")
                        .HasColumnType("numeric")
                        .HasColumnName("ampere_ac");

                    b.Property<decimal>("ampere_ac_2")
                        .HasColumnType("numeric")
                        .HasColumnName("ampere_ac_2");

                    b.Property<decimal>("ampere_dc")
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("numeric")
                        .HasColumnName("ampere_dc");

                    b.Property<decimal>("ampere_dc_2")
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("numeric")
                        .HasColumnName("ampere_dc");

                    b.Property<string>("controller")
                        .HasColumnType("text");

                    b.Property<string>("ip")
                        .HasColumnType("text")
                        .HasColumnName("ip");

                    b.Property<string>("lokasi")
                        .HasColumnType("text")
                        .HasColumnName("lokasi");

                    b.Property<string>("mac")
                        .HasColumnType("text")
                        .HasColumnName("mac");

                    b.Property<decimal>("voltage_ac")
                        .HasColumnType("numeric")
                        .HasColumnName("voltage_ac");

                    b.Property<decimal>("voltage_ac_2")
                        .HasColumnType("numeric")
                        .HasColumnName("voltage_ac_2");

                    b.Property<decimal>("voltage_dc")
                        .HasColumnType("numeric")
                        .HasColumnName("voltage_dc");

                    b.Property<decimal>("voltage_dc_2")
                        .HasColumnType("numeric")
                        .HasColumnName("voltage_dc_2");

                    b.Property<DateTime>("waktu")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("id");

                    b.ToTable("ms06");
                });
#pragma warning restore 612, 618
        }
    }
}
