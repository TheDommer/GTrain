﻿// <auto-generated />
using System;
using GTrain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GTrain.Migrations
{
    [DbContext(typeof(TrainingDbContext))]
    partial class TrainingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GTrain.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("GTrain.Models.Topic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("GTrain.Models.TopicCategory", b =>
                {
                    b.Property<int>("TopicID");

                    b.Property<int>("CategoryID");

                    b.Property<int?>("CategoryID1");

                    b.Property<int?>("CategoryTopicID");

                    b.HasKey("TopicID", "CategoryID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("CategoryTopicID", "CategoryID1");

                    b.ToTable("TopicCategories");
                });

            modelBuilder.Entity("GTrain.Models.TopicCategory", b =>
                {
                    b.HasOne("GTrain.Models.Category")
                        .WithMany("TopicCategories")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GTrain.Models.Topic", "Topic")
                        .WithMany("TopicCategories")
                        .HasForeignKey("TopicID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GTrain.Models.TopicCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryTopicID", "CategoryID1");
                });
#pragma warning restore 612, 618
        }
    }
}
