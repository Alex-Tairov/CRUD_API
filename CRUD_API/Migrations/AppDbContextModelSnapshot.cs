﻿// <auto-generated />
using CRUD_API.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUD_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CRUD_API.Models.Resident", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Residents");

                    b.HasData(
                        new
                        {
                            Id = "qyfgqiyhwfoq1",
                            Age = 30,
                            Name = "Stan Smith",
                            Sex = "male"
                        },
                        new
                        {
                            Id = "qmvqqwrqsds2",
                            Age = 14,
                            Name = "Jack Anderson",
                            Sex = "male"
                        },
                        new
                        {
                            Id = "vdhgqvgj3",
                            Age = 24,
                            Name = "Olga Popova",
                            Sex = "female"
                        },
                        new
                        {
                            Id = "lkqjweiojqiow4",
                            Age = 31,
                            Name = "Erzhena Koroleva",
                            Sex = "female"
                        },
                        new
                        {
                            Id = "hqwuiehquikxhc5",
                            Age = 42,
                            Name = "German Titov",
                            Sex = "male"
                        },
                        new
                        {
                            Id = "guyqwhoij6",
                            Age = 78,
                            Name = "Dmitry Vegas",
                            Sex = "male"
                        },
                        new
                        {
                            Id = "kjlqwoijeo7",
                            Age = 41,
                            Name = "Solomon Shlemovich",
                            Sex = "male"
                        },
                        new
                        {
                            Id = "lkkpokqw8",
                            Age = 45,
                            Name = "Alex Whitedrinker",
                            Sex = "female"
                        },
                        new
                        {
                            Id = "acmwojeiwqe9",
                            Age = 19,
                            Name = "Anna Titova",
                            Sex = "female"
                        },
                        new
                        {
                            Id = "qjIdwojqiowj10",
                            Age = 63,
                            Name = "Elmo Kennedy",
                            Sex = "male"
                        },
                        new
                        {
                            Id = "cnoqjpIdjkqpo11",
                            Age = 11,
                            Name = "Sascha Braemer",
                            Sex = "male"
                        },
                        new
                        {
                            Id = "ajkvdnLdj22po11",
                            Age = 27,
                            Name = "Pishkun Vladislav",
                            Sex = "male"
                        },
                        new
                        {
                            Id = "djkqpo11cnoqjpI",
                            Age = 31,
                            Name = "Jessica Braemer",
                            Sex = "female"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}