﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
// using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model;

namespace Model.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Restaurant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BannerRestaurant");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("LogoRestaurant");

                    b.Property<string>("NomeRestaurant");

                    b.Property<bool>("Status");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("Model.Teste", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Teste");
                });
#pragma warning restore 612, 618
        }
    }
}
