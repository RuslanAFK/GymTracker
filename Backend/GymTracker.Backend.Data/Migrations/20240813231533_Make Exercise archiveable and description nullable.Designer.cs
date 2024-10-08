﻿// <auto-generated />
using System;
using System.Collections.Generic;
using GymTracker.Backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GymTracker.Backend.Data.Migrations
{
    [DbContext(typeof(TrackerDbContext))]
    [Migration("20240813231533_Make Exercise archiveable and description nullable")]
    partial class MakeExercisearchiveableanddescriptionnullable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GymTracker.Backend.Data.DataModels.Exercise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Archived")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Exercise");
                });

            modelBuilder.Entity("GymTracker.Backend.Data.DataModels.Record", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ExerciseId")
                        .HasColumnType("uniqueidentifier");

                    b.ComplexProperty<Dictionary<string, object>>("AdditionalWeight", "GymTracker.Backend.Data.DataModels.Record.AdditionalWeight#Weight", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<bool>("IsDoubled")
                                .HasColumnType("bit");

                            b1.Property<int>("Unit")
                                .HasColumnType("int");

                            b1.Property<long>("Value")
                                .HasColumnType("bigint");
                        });

                    b.ComplexProperty<Dictionary<string, object>>("Weight", "GymTracker.Backend.Data.DataModels.Record.Weight#Weight", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<bool>("IsDoubled")
                                .HasColumnType("bit");

                            b1.Property<int>("Unit")
                                .HasColumnType("int");

                            b1.Property<long>("Value")
                                .HasColumnType("bigint");
                        });

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.ToTable("Record");
                });

            modelBuilder.Entity("GymTracker.Backend.Data.DataModels.Record", b =>
                {
                    b.HasOne("GymTracker.Backend.Data.DataModels.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");
                });
#pragma warning restore 612, 618
        }
    }
}
