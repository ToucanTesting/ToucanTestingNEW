﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToucanTesting.Data;

namespace ToucanTesting.Data.Migrations
{
    [DbContext(typeof(ToucanDbContext))]
    partial class ToucanDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ToucanTesting.Data.Models.Module", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime?>("DisabledAt");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<int>("Sequence");

                    b.Property<long?>("SuiteId");

                    b.Property<Guid>("TentantId");

                    b.HasKey("Id");

                    b.HasIndex("SuiteId");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("ToucanTesting.Data.Models.Suite", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("IsEnabled");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<Guid>("TentantId");

                    b.HasKey("Id");

                    b.ToTable("Suites");
                });

            modelBuilder.Entity("ToucanTesting.Data.Models.Tenant", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("ToucanTesting.Data.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Email");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<long?>("TenantId");

                    b.Property<Guid>("TentantId");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ToucanTesting.Data.Models.Module", b =>
                {
                    b.HasOne("ToucanTesting.Data.Models.Suite")
                        .WithMany("Modules")
                        .HasForeignKey("SuiteId");
                });

            modelBuilder.Entity("ToucanTesting.Data.Models.User", b =>
                {
                    b.HasOne("ToucanTesting.Data.Models.Tenant")
                        .WithMany("Users")
                        .HasForeignKey("TenantId");
                });
#pragma warning restore 612, 618
        }
    }
}