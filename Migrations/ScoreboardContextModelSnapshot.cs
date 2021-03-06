﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using msaPhase2.Data;

namespace msaPhase2.Migrations
{
    [DbContext(typeof(ScoreboardContext))]
    partial class ScoreboardContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("msaPhase2.Models.Scoreboard", b =>
                {
                    b.Property<int>("scoreboardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("playerO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("playerX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("timeCreated")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("winner")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("scoreboardId");

                    b.ToTable("Scoreboard");
                });
#pragma warning restore 612, 618
        }
    }
}
