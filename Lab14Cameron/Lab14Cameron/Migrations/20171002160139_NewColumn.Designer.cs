﻿// <auto-generated />
using Lab14Cameron.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Lab14Cameron.Migrations
{
    [DbContext(typeof(Lab14CameronContext))]
    [Migration("20171002160139_NewColumn")]
    partial class NewColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab14Cameron.Models.Register", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Albums");

                    b.Property<DateTime>("FirstAlbum");

                    b.Property<string>("FirstAlbumTitle");

                    b.Property<string>("HomeState")
                        .IsRequired();

                    b.Property<string>("Hometown")
                        .IsRequired();

                    b.Property<string>("MC")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Register");
                });
#pragma warning restore 612, 618
        }
    }
}
