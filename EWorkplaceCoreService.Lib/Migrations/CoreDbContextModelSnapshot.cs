﻿// <auto-generated />
using EWorkplaceCoreService.Lib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EWorkplaceCoreService.Lib.Migrations
{
    [DbContext(typeof(CoreDbContext))]
    partial class CoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EWorkplaceCoreService.Lib.Models.Division", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Divisions");
                });

            modelBuilder.Entity("EWorkplaceCoreService.Lib.Models.JobTitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<string>("CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreatedUtc");

                    b.Property<string>("DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DeletedUtc");

                    b.Property<string>("Description");

                    b.Property<int>("DivisionId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModifiedUtc");

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("JobTitles");
                });
#pragma warning restore 612, 618
        }
    }
}
