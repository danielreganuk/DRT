﻿// <auto-generated />
using System;
using DRT.Persistence.MySQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DRT.Persistence.MySQL.Migrations
{
    [DbContext(typeof(MySqlDRTDbContext))]
    partial class MySqlDRTDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DRT.Domain.Entities.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("varchar(64) CHARACTER SET utf8mb4")
                        .HasMaxLength(64);

                    b.HasKey("AccountId");

                    b.HasIndex("AccountName");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("DRT.Domain.Entities.AccountUser", b =>
                {
                    b.Property<int>("AccountUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("varchar(128) CHARACTER SET utf8mb4")
                        .HasMaxLength(128);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(64) CHARACTER SET utf8mb4")
                        .HasMaxLength(64);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(64) CHARACTER SET utf8mb4")
                        .HasMaxLength(64);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(64) CHARACTER SET utf8mb4")
                        .HasMaxLength(64);

                    b.HasKey("AccountUserId");

                    b.HasIndex("AccountId");

                    b.ToTable("AccountUsers");
                });

            modelBuilder.Entity("DRT.Domain.Entities.Case", b =>
                {
                    b.Property<int>("CaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("Classification")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ClosedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("OpenedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("UserFriendlyId")
                        .IsRequired()
                        .HasColumnType("varchar(6) CHARACTER SET utf8mb4")
                        .HasMaxLength(6);

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CaseId");

                    b.HasIndex("AccountId");

                    b.HasIndex("UserFriendlyId");

                    b.HasIndex("UserId");

                    b.ToTable("Cases");
                });

            modelBuilder.Entity("DRT.Domain.Entities.CaseNote", b =>
                {
                    b.Property<int>("CaseNoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CaseId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("NoteDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CaseNoteId");

                    b.HasIndex("CaseId");

                    b.HasIndex("UserId");

                    b.ToTable("CaseNotes");
                });

            modelBuilder.Entity("DRT.Domain.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("varchar(128) CHARACTER SET utf8mb4")
                        .HasMaxLength(128);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(64) CHARACTER SET utf8mb4")
                        .HasMaxLength(64);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(64) CHARACTER SET utf8mb4")
                        .HasMaxLength(64);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(64) CHARACTER SET utf8mb4")
                        .HasMaxLength(64);

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DRT.Domain.Entities.AccountUser", b =>
                {
                    b.HasOne("DRT.Domain.Entities.Account", "Account")
                        .WithMany("Users")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DRT.Domain.Entities.Case", b =>
                {
                    b.HasOne("DRT.Domain.Entities.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DRT.Domain.Entities.User", "User")
                        .WithMany("Cases")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DRT.Domain.Entities.CaseNote", b =>
                {
                    b.HasOne("DRT.Domain.Entities.Case", "Case")
                        .WithMany("Notes")
                        .HasForeignKey("CaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DRT.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
