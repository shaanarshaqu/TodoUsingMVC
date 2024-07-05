﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoUsingMVC.Data;

#nullable disable

namespace TodoUsingMVC.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20240705171608_inserted_some_dummy_datas_to_todo")]
    partial class inserted_some_dummy_datas_to_todo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TodoUsingMVC.Models.Todo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TodoTb");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Title = "watch movie"
                        },
                        new
                        {
                            Id = "2",
                            Title = "play games"
                        },
                        new
                        {
                            Id = "3",
                            Title = "eat food"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
