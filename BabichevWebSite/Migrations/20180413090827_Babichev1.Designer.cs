﻿// <auto-generated />
using BabichevWebSite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace BabichevWebSite.Migrations
{
    [DbContext(typeof(BabichevDbContext))]
    [Migration("20180413090827_Babichev1")]
    partial class Babichev1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BabichevWebSite.Data.UserProfiles", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("UserId");

                    b.ToTable("UserProfiles");
                });
#pragma warning restore 612, 618
        }
    }
}