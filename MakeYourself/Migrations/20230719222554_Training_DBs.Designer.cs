﻿// <auto-generated />
using System;
using MakeYourself.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MakeYourself.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230719222554_Training_DBs")]
    partial class Training_DBs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MakeYourself.Models.Calendar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Calendars");
                });

            modelBuilder.Entity("MakeYourself.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FIO")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Height")
                        .HasPrecision(3, 2)
                        .HasColumnType("double");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<int>("PhysiqueId")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("PhysiqueId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("MakeYourself.Models.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("MakeYourself.Models.Physique", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Physiques");
                });

            modelBuilder.Entity("MakeYourself.Models.TrainDay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<sbyte>("ActualReps")
                        .HasColumnType("tinyint");

                    b.Property<int>("CalendarId")
                        .HasColumnType("int");

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<sbyte>("GoalReps")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("CalendarId");

                    b.HasIndex("ExerciseId");

                    b.ToTable("TrainDays");
                });

            modelBuilder.Entity("MakeYourself.Models.Calendar", b =>
                {
                    b.HasOne("MakeYourself.Models.Client", "Clients")
                        .WithMany("Calendars")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clients");
                });

            modelBuilder.Entity("MakeYourself.Models.Client", b =>
                {
                    b.HasOne("MakeYourself.Models.Physique", "Physique")
                        .WithMany("Clients")
                        .HasForeignKey("PhysiqueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Physique");
                });

            modelBuilder.Entity("MakeYourself.Models.TrainDay", b =>
                {
                    b.HasOne("MakeYourself.Models.Calendar", "Calendar")
                        .WithMany("TrainDays")
                        .HasForeignKey("CalendarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MakeYourself.Models.Exercise", "Exercise")
                        .WithMany("TrainDays")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calendar");

                    b.Navigation("Exercise");
                });

            modelBuilder.Entity("MakeYourself.Models.Calendar", b =>
                {
                    b.Navigation("TrainDays");
                });

            modelBuilder.Entity("MakeYourself.Models.Client", b =>
                {
                    b.Navigation("Calendars");
                });

            modelBuilder.Entity("MakeYourself.Models.Exercise", b =>
                {
                    b.Navigation("TrainDays");
                });

            modelBuilder.Entity("MakeYourself.Models.Physique", b =>
                {
                    b.Navigation("Clients");
                });
#pragma warning restore 612, 618
        }
    }
}
