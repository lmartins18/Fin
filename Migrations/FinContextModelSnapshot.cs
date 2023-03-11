﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using fin;

#nullable disable

namespace fin.Migrations
{
    [DbContext(typeof(FinContext))]
    partial class FinContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("fin.Models.Concrete.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal?>("Balance")
                        .HasColumnType("numeric")
                        .HasColumnName("balance");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("integer")
                        .HasColumnName("category_id");

                    b.Property<int?>("Icon")
                        .HasColumnType("integer")
                        .HasColumnName("icon");

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("accounts_pkey");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Icon");

                    b.ToTable("accounts", (string)null);
                });

            modelBuilder.Entity("fin.Models.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("categories_pkey");

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("fin.Models.Concrete.Goal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal?>("AmountAchieved")
                        .HasColumnType("numeric")
                        .HasColumnName("amount_achieved");

                    b.Property<decimal?>("AmountToAchieve")
                        .HasColumnType("numeric")
                        .HasColumnName("amount_to_achieve");

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("goals_pkey");

                    b.ToTable("goals", (string)null);
                });

            modelBuilder.Entity("fin.Models.Concrete.Icon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("icons_pkey");

                    b.ToTable("icons", (string)null);
                });

            modelBuilder.Entity("fin.Models.Concrete.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AccountId")
                        .HasColumnType("integer")
                        .HasColumnName("account_id");

                    b.Property<decimal?>("Amount")
                        .HasColumnType("numeric")
                        .HasColumnName("amount");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("integer")
                        .HasColumnName("category_id");

                    b.Property<bool?>("Credit")
                        .HasColumnType("boolean")
                        .HasColumnName("credit");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date");

                    b.Property<string>("Name")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("transactions_pkey");

                    b.HasIndex("AccountId");

                    b.HasIndex("CategoryId");

                    b.ToTable("transactions", (string)null);
                });

            modelBuilder.Entity("fin.Models.Concrete.Account", b =>
                {
                    b.HasOne("fin.Models.Concrete.Category", "Category")
                        .WithMany("Accounts")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("accounts_category_id_fkey");

                    b.HasOne("fin.Models.Concrete.Icon", "IconNavigation")
                        .WithMany("Accounts")
                        .HasForeignKey("Icon")
                        .HasConstraintName("accounts_icon_fkey");

                    b.Navigation("Category");

                    b.Navigation("IconNavigation");
                });

            modelBuilder.Entity("fin.Models.Concrete.Transaction", b =>
                {
                    b.HasOne("fin.Models.Concrete.Account", "Account")
                        .WithMany("Transactions")
                        .HasForeignKey("AccountId")
                        .HasConstraintName("transactions_account_id_fkey");

                    b.HasOne("fin.Models.Concrete.Category", "Category")
                        .WithMany("Transactions")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("transactions_category_id_fkey");

                    b.Navigation("Account");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("fin.Models.Concrete.Account", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("fin.Models.Concrete.Category", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("fin.Models.Concrete.Icon", b =>
                {
                    b.Navigation("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}