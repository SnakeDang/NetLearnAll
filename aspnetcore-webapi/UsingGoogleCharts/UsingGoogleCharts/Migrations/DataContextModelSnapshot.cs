﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("API.Model.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SpeakersInMillions")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "English",
                            SpeakersInMillions = 1132
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mandarin",
                            SpeakersInMillions = 1117
                        },
                        new
                        {
                            Id = 3,
                            Name = "Hindi",
                            SpeakersInMillions = 665
                        },
                        new
                        {
                            Id = 4,
                            Name = "Spanish",
                            SpeakersInMillions = 534
                        },
                        new
                        {
                            Id = 5,
                            Name = "French",
                            SpeakersInMillions = 280
                        },
                        new
                        {
                            Id = 6,
                            Name = "Arabic",
                            SpeakersInMillions = 274
                        },
                        new
                        {
                            Id = 7,
                            Name = "Bengali",
                            SpeakersInMillions = 265
                        },
                        new
                        {
                            Id = 8,
                            Name = "Russian",
                            SpeakersInMillions = 258
                        },
                        new
                        {
                            Id = 9,
                            Name = "Portuguese",
                            SpeakersInMillions = 234
                        },
                        new
                        {
                            Id = 10,
                            Name = "Indonesian",
                            SpeakersInMillions = 198
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
