﻿// <auto-generated />
using ApiMpu9250.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiMpu9250.Migrations
{
    [DbContext(typeof(MPUDbContext))]
    [Migration("20231215084415_UpdateMPU")]
    partial class UpdateMPU
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ApiMpu9250.Domain.MPU", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<float>("Ax")
                        .HasColumnType("real");

                    b.Property<float>("Ay")
                        .HasColumnType("real");

                    b.Property<float>("Az")
                        .HasColumnType("real");

                    b.Property<float>("Gx")
                        .HasColumnType("real");

                    b.Property<float>("Gy")
                        .HasColumnType("real");

                    b.Property<float>("Gz")
                        .HasColumnType("real");

                    b.Property<float>("Mx")
                        .HasColumnType("real");

                    b.Property<float>("My")
                        .HasColumnType("real");

                    b.Property<float>("Mz")
                        .HasColumnType("real");

                    b.Property<float>("Pitch")
                        .HasColumnType("real");

                    b.Property<float>("Roll")
                        .HasColumnType("real");

                    b.Property<float>("Yaw")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Mpus");
                });
#pragma warning restore 612, 618
        }
    }
}
