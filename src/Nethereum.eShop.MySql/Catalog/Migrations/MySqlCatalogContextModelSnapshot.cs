﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nethereum.eShop.MySql.Catalog;

namespace Nethereum.eShop.MySql.Catalog.Migrations
{
    [DbContext(typeof(MySqlCatalogContext))]
    partial class MySqlCatalogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.BasketAggregate.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BuyerAddress")
                        .IsRequired()
                        .HasColumnType("varchar(43) CHARACTER SET utf8mb4")
                        .HasMaxLength(43);

                    b.Property<string>("BuyerId")
                        .IsRequired()
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("TransactionHash")
                        .HasColumnType("varchar(67) CHARACTER SET utf8mb4")
                        .HasMaxLength(67);

                    b.HasKey("Id");

                    b.HasIndex("BuyerAddress");

                    b.HasIndex("BuyerId");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.BasketAggregate.BasketItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BasketId")
                        .HasColumnType("int");

                    b.Property<int>("CatalogItemId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.ToTable("BasketItems");
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.BuyerAggregate.Buyer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BuyerAddress")
                        .HasColumnType("varchar(43) CHARACTER SET utf8mb4")
                        .HasMaxLength(43);

                    b.Property<string>("BuyerId")
                        .IsRequired()
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("BuyerWalletAddress")
                        .HasColumnType("varchar(43) CHARACTER SET utf8mb4")
                        .HasMaxLength(43);

                    b.HasKey("Id");

                    b.HasIndex("BuyerAddress")
                        .IsUnique();

                    b.HasIndex("BuyerId")
                        .IsUnique();

                    b.HasIndex("BuyerWalletAddress")
                        .IsUnique();

                    b.ToTable("Buyers");
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.BuyerAggregate.BuyerPostalAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("BuyerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.ToTable("BuyerPostalAddress");
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.CatalogBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("CatalogBrands");
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.CatalogItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AttributeJson")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("CatalogBrandId")
                        .HasColumnType("int");

                    b.Property<int>("CatalogTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Depth")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Gtin")
                        .IsRequired()
                        .HasColumnType("varchar(14) CHARACTER SET utf8mb4")
                        .HasMaxLength(14);

                    b.Property<int?>("GtinRegistryId")
                        .HasColumnType("int");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("PictureLargeUri")
                        .HasColumnType("varchar(512) CHARACTER SET utf8mb4")
                        .HasMaxLength(512);

                    b.Property<string>("PictureMediumUri")
                        .HasColumnType("varchar(512) CHARACTER SET utf8mb4")
                        .HasMaxLength(512);

                    b.Property<string>("PictureSmallUri")
                        .HasColumnType("varchar(512) CHARACTER SET utf8mb4")
                        .HasMaxLength(512);

                    b.Property<string>("PictureUri")
                        .HasColumnType("varchar(512) CHARACTER SET utf8mb4")
                        .HasMaxLength(512);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .HasColumnType("varchar(8) CHARACTER SET utf8mb4")
                        .HasMaxLength(8);

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CatalogBrandId");

                    b.HasIndex("CatalogTypeId");

                    b.ToTable("Catalog");
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.CatalogType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("CatalogTypes");
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.OrderAggregate.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BuyerId")
                        .IsRequired()
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("BuyerWalletAddress")
                        .HasColumnType("varchar(43) CHARACTER SET utf8mb4")
                        .HasMaxLength(43);

                    b.Property<string>("CurrencyAddress")
                        .HasColumnType("varchar(43) CHARACTER SET utf8mb4")
                        .HasMaxLength(43);

                    b.Property<string>("CurrencySymbol")
                        .HasColumnType("varchar(32) CHARACTER SET utf8mb4")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("OrderDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTimeOffset?>("PoDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("PoNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("PoType")
                        .HasColumnType("int");

                    b.Property<int?>("QuoteId")
                        .HasColumnType("int");

                    b.Property<string>("SellerId")
                        .HasColumnType("varchar(32) CHARACTER SET utf8mb4")
                        .HasMaxLength(32);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TransactionHash")
                        .HasColumnType("varchar(67) CHARACTER SET utf8mb4")
                        .HasMaxLength(67);

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.OrderAggregate.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("ActualEscrowReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CurrencyValue")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<DateTimeOffset?>("GoodsIssueDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool?>("IsEscrowReleased")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("PlannedEscrowReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("PoItemNumber")
                        .HasColumnType("int");

                    b.Property<int?>("PoItemStatus")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("QuantityAddress")
                        .HasColumnType("varchar(43) CHARACTER SET utf8mb4")
                        .HasMaxLength(43);

                    b.Property<string>("QuantitySymbol")
                        .HasColumnType("varchar(32) CHARACTER SET utf8mb4")
                        .HasMaxLength(32);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.QuoteAggregate.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ApproverAddress")
                        .HasColumnType("varchar(43) CHARACTER SET utf8mb4")
                        .HasMaxLength(43);

                    b.Property<string>("BuyerAddress")
                        .HasColumnType("varchar(43) CHARACTER SET utf8mb4")
                        .HasMaxLength(43);

                    b.Property<string>("BuyerId")
                        .IsRequired()
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("BuyerWalletAddress")
                        .HasColumnType("varchar(43) CHARACTER SET utf8mb4")
                        .HasMaxLength(43);

                    b.Property<string>("CurrencyAddress")
                        .HasColumnType("varchar(43) CHARACTER SET utf8mb4")
                        .HasMaxLength(43);

                    b.Property<string>("CurrencySymbol")
                        .HasColumnType("varchar(32) CHARACTER SET utf8mb4")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTimeOffset>("Expiry")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("PoNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("PoType")
                        .HasColumnType("int");

                    b.Property<string>("SellerId")
                        .HasColumnType("varchar(32) CHARACTER SET utf8mb4")
                        .HasMaxLength(32);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TransactionHash")
                        .HasColumnType("varchar(67) CHARACTER SET utf8mb4")
                        .HasMaxLength(67);

                    b.HasKey("Id");

                    b.HasIndex("BuyerAddress");

                    b.HasIndex("BuyerId");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.QuoteAggregate.QuoteItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CurrencyValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTimeOffset?>("EscrowReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("PoItemNumber")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("QuantityAddress")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("QuantitySymbol")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("QuoteId")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("QuoteId");

                    b.ToTable("QuoteItems");
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.StockItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CatalogItemId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CatalogItemId");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.BasketAggregate.Basket", b =>
                {
                    b.OwnsOne("Nethereum.eShop.ApplicationCore.Entities.PostalAddress", "BillTo", b1 =>
                        {
                            b1.Property<int>("BasketId")
                                .HasColumnType("int");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                                .HasMaxLength(100);

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("varchar(90) CHARACTER SET utf8mb4")
                                .HasMaxLength(90);

                            b1.Property<string>("RecipientName")
                                .IsRequired()
                                .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                                .HasMaxLength(255);

                            b1.Property<string>("State")
                                .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                                .HasMaxLength(60);

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("varchar(180) CHARACTER SET utf8mb4")
                                .HasMaxLength(180);

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasColumnType("varchar(18) CHARACTER SET utf8mb4")
                                .HasMaxLength(18);

                            b1.HasKey("BasketId");

                            b1.ToTable("Baskets");

                            b1.WithOwner()
                                .HasForeignKey("BasketId");
                        });

                    b.OwnsOne("Nethereum.eShop.ApplicationCore.Entities.PostalAddress", "ShipTo", b1 =>
                        {
                            b1.Property<int>("BasketId")
                                .HasColumnType("int");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                                .HasMaxLength(100);

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("varchar(90) CHARACTER SET utf8mb4")
                                .HasMaxLength(90);

                            b1.Property<string>("RecipientName")
                                .IsRequired()
                                .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                                .HasMaxLength(255);

                            b1.Property<string>("State")
                                .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                                .HasMaxLength(60);

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("varchar(180) CHARACTER SET utf8mb4")
                                .HasMaxLength(180);

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasColumnType("varchar(18) CHARACTER SET utf8mb4")
                                .HasMaxLength(18);

                            b1.HasKey("BasketId");

                            b1.ToTable("Baskets");

                            b1.WithOwner()
                                .HasForeignKey("BasketId");
                        });
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.BasketAggregate.BasketItem", b =>
                {
                    b.HasOne("Nethereum.eShop.ApplicationCore.Entities.BasketAggregate.Basket", null)
                        .WithMany("Items")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.BuyerAggregate.BuyerPostalAddress", b =>
                {
                    b.HasOne("Nethereum.eShop.ApplicationCore.Entities.BuyerAggregate.Buyer", null)
                        .WithMany("PostalAddresses")
                        .HasForeignKey("BuyerId");

                    b.OwnsOne("Nethereum.eShop.ApplicationCore.Entities.PostalAddress", "PostalAddress", b1 =>
                        {
                            b1.Property<int>("BuyerPostalAddressId")
                                .HasColumnType("int");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                                .HasMaxLength(100);

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("varchar(90) CHARACTER SET utf8mb4")
                                .HasMaxLength(90);

                            b1.Property<string>("RecipientName")
                                .IsRequired()
                                .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                                .HasMaxLength(255);

                            b1.Property<string>("State")
                                .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                                .HasMaxLength(60);

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("varchar(180) CHARACTER SET utf8mb4")
                                .HasMaxLength(180);

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasColumnType("varchar(18) CHARACTER SET utf8mb4")
                                .HasMaxLength(18);

                            b1.HasKey("BuyerPostalAddressId");

                            b1.ToTable("BuyerPostalAddress");

                            b1.WithOwner()
                                .HasForeignKey("BuyerPostalAddressId");
                        });
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.CatalogItem", b =>
                {
                    b.HasOne("Nethereum.eShop.ApplicationCore.Entities.CatalogBrand", "CatalogBrand")
                        .WithMany()
                        .HasForeignKey("CatalogBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nethereum.eShop.ApplicationCore.Entities.CatalogType", "CatalogType")
                        .WithMany()
                        .HasForeignKey("CatalogTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.OrderAggregate.Order", b =>
                {
                    b.OwnsOne("Nethereum.eShop.ApplicationCore.Entities.PostalAddress", "BillTo", b1 =>
                        {
                            b1.Property<int>("OrderId")
                                .HasColumnType("int");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                                .HasMaxLength(100);

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("varchar(90) CHARACTER SET utf8mb4")
                                .HasMaxLength(90);

                            b1.Property<string>("RecipientName")
                                .IsRequired()
                                .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                                .HasMaxLength(255);

                            b1.Property<string>("State")
                                .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                                .HasMaxLength(60);

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("varchar(180) CHARACTER SET utf8mb4")
                                .HasMaxLength(180);

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasColumnType("varchar(18) CHARACTER SET utf8mb4")
                                .HasMaxLength(18);

                            b1.HasKey("OrderId");

                            b1.ToTable("Orders");

                            b1.WithOwner()
                                .HasForeignKey("OrderId");
                        });

                    b.OwnsOne("Nethereum.eShop.ApplicationCore.Entities.PostalAddress", "ShipTo", b1 =>
                        {
                            b1.Property<int>("OrderId")
                                .HasColumnType("int");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                                .HasMaxLength(100);

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("varchar(90) CHARACTER SET utf8mb4")
                                .HasMaxLength(90);

                            b1.Property<string>("RecipientName")
                                .IsRequired()
                                .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                                .HasMaxLength(255);

                            b1.Property<string>("State")
                                .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                                .HasMaxLength(60);

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("varchar(180) CHARACTER SET utf8mb4")
                                .HasMaxLength(180);

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasColumnType("varchar(18) CHARACTER SET utf8mb4")
                                .HasMaxLength(18);

                            b1.HasKey("OrderId");

                            b1.ToTable("Orders");

                            b1.WithOwner()
                                .HasForeignKey("OrderId");
                        });
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.OrderAggregate.OrderItem", b =>
                {
                    b.HasOne("Nethereum.eShop.ApplicationCore.Entities.OrderAggregate.Order", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId");

                    b.OwnsOne("Nethereum.eShop.ApplicationCore.Entities.CatalogItemExcerpt", "ItemOrdered", b1 =>
                        {
                            b1.Property<int>("OrderItemId")
                                .HasColumnType("int");

                            b1.Property<int>("CatalogItemId")
                                .HasColumnType("int");

                            b1.Property<string>("Gtin")
                                .HasColumnType("varchar(14) CHARACTER SET utf8mb4")
                                .HasMaxLength(14);

                            b1.Property<int?>("GtinRegistryId")
                                .HasColumnType("int");

                            b1.Property<string>("PictureUri")
                                .HasColumnType("varchar(512) CHARACTER SET utf8mb4")
                                .HasMaxLength(512);

                            b1.Property<string>("ProductName")
                                .IsRequired()
                                .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                                .HasMaxLength(50);

                            b1.HasKey("OrderItemId");

                            b1.ToTable("OrderItems");

                            b1.WithOwner()
                                .HasForeignKey("OrderItemId");
                        });
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.QuoteAggregate.Quote", b =>
                {
                    b.OwnsOne("Nethereum.eShop.ApplicationCore.Entities.PostalAddress", "BillTo", b1 =>
                        {
                            b1.Property<int>("QuoteId")
                                .HasColumnType("int");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                                .HasMaxLength(100);

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("varchar(90) CHARACTER SET utf8mb4")
                                .HasMaxLength(90);

                            b1.Property<string>("RecipientName")
                                .IsRequired()
                                .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                                .HasMaxLength(255);

                            b1.Property<string>("State")
                                .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                                .HasMaxLength(60);

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("varchar(180) CHARACTER SET utf8mb4")
                                .HasMaxLength(180);

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasColumnType("varchar(18) CHARACTER SET utf8mb4")
                                .HasMaxLength(18);

                            b1.HasKey("QuoteId");

                            b1.ToTable("Quotes");

                            b1.WithOwner()
                                .HasForeignKey("QuoteId");
                        });

                    b.OwnsOne("Nethereum.eShop.ApplicationCore.Entities.PostalAddress", "ShipTo", b1 =>
                        {
                            b1.Property<int>("QuoteId")
                                .HasColumnType("int");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                                .HasMaxLength(100);

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("varchar(90) CHARACTER SET utf8mb4")
                                .HasMaxLength(90);

                            b1.Property<string>("RecipientName")
                                .IsRequired()
                                .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                                .HasMaxLength(255);

                            b1.Property<string>("State")
                                .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                                .HasMaxLength(60);

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("varchar(180) CHARACTER SET utf8mb4")
                                .HasMaxLength(180);

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasColumnType("varchar(18) CHARACTER SET utf8mb4")
                                .HasMaxLength(18);

                            b1.HasKey("QuoteId");

                            b1.ToTable("Quotes");

                            b1.WithOwner()
                                .HasForeignKey("QuoteId");
                        });
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.QuoteAggregate.QuoteItem", b =>
                {
                    b.HasOne("Nethereum.eShop.ApplicationCore.Entities.QuoteAggregate.Quote", null)
                        .WithMany("QuoteItems")
                        .HasForeignKey("QuoteId");

                    b.OwnsOne("Nethereum.eShop.ApplicationCore.Entities.CatalogItemExcerpt", "ItemOrdered", b1 =>
                        {
                            b1.Property<int>("QuoteItemId")
                                .HasColumnType("int");

                            b1.Property<int>("CatalogItemId")
                                .HasColumnType("int");

                            b1.Property<string>("Gtin")
                                .HasColumnType("varchar(14) CHARACTER SET utf8mb4")
                                .HasMaxLength(14);

                            b1.Property<int?>("GtinRegistryId")
                                .HasColumnType("int");

                            b1.Property<string>("PictureUri")
                                .HasColumnType("varchar(512) CHARACTER SET utf8mb4")
                                .HasMaxLength(512);

                            b1.Property<string>("ProductName")
                                .IsRequired()
                                .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                                .HasMaxLength(50);

                            b1.HasKey("QuoteItemId");

                            b1.ToTable("QuoteItems");

                            b1.WithOwner()
                                .HasForeignKey("QuoteItemId");
                        });
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.StockItem", b =>
                {
                    b.HasOne("Nethereum.eShop.ApplicationCore.Entities.CatalogItem", "CatalogItem")
                        .WithMany()
                        .HasForeignKey("CatalogItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
