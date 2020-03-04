﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nethereum.eShop.Infrastructure.Data;

namespace Nethereum.eShop.Infrastructure.Data.Migrations
{
    [DbContext(typeof(CatalogContext))]
    [Migration("20200304170042_ResizeColumns")]
    partial class ResizeColumns
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("Relational:Sequence:.catalog_brand_hilo", "'catalog_brand_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.catalog_hilo", "'catalog_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.catalog_type_hilo", "'catalog_type_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.stock_hilo", "'stock_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.BasketAggregate.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BuyerAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(43)")
                        .HasMaxLength(43);

                    b.Property<string>("BuyerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("TransactionHash")
                        .HasColumnType("nvarchar(67)")
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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BuyerAddress")
                        .HasColumnType("nvarchar(43)")
                        .HasMaxLength(43);

                    b.Property<string>("BuyerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("BuyerAddress")
                        .IsUnique()
                        .HasFilter("[BuyerAddress] IS NOT NULL");

                    b.HasIndex("BuyerId")
                        .IsUnique();

                    b.ToTable("Buyers");
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.BuyerAggregate.BuyerPostalAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BuyerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.ToTable("BuyerPostalAddress");
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.CatalogBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:HiLoSequenceName", "catalog_brand_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("CatalogBrands");
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.CatalogItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:HiLoSequenceName", "catalog_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("AttributeJson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CatalogBrandId")
                        .HasColumnType("int");

                    b.Property<int>("CatalogTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Depth")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gtin")
                        .IsRequired()
                        .HasColumnType("nvarchar(14)")
                        .HasMaxLength(14);

                    b.Property<int?>("GtinRegistryId")
                        .HasColumnType("int");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PictureLargeUri")
                        .HasColumnType("nvarchar(512)")
                        .HasMaxLength(512);

                    b.Property<string>("PictureMediumUri")
                        .HasColumnType("nvarchar(512)")
                        .HasMaxLength(512);

                    b.Property<string>("PictureSmallUri")
                        .HasColumnType("nvarchar(512)")
                        .HasMaxLength(512);

                    b.Property<string>("PictureUri")
                        .HasColumnType("nvarchar(512)")
                        .HasMaxLength(512);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(8)")
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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:HiLoSequenceName", "catalog_type_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("CatalogTypes");
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.OrderAggregate.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApproverAddress")
                        .HasColumnType("nvarchar(43)")
                        .HasMaxLength(43);

                    b.Property<string>("BuyerAddress")
                        .HasColumnType("nvarchar(43)")
                        .HasMaxLength(43);

                    b.Property<string>("BuyerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("BuyerWalletAddress")
                        .HasColumnType("nvarchar(43)")
                        .HasMaxLength(43);

                    b.Property<string>("CurrencyAddress")
                        .HasColumnType("nvarchar(43)")
                        .HasMaxLength(43);

                    b.Property<string>("CurrencySymbol")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("OrderDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("PoDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<long?>("PoNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("PoType")
                        .HasColumnType("int");

                    b.Property<int?>("QuoteId")
                        .HasColumnType("int");

                    b.Property<string>("SellerId")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TransactionHash")
                        .HasColumnType("nvarchar(67)")
                        .HasMaxLength(67);

                    b.HasKey("Id");

                    b.HasIndex("BuyerAddress");

                    b.HasIndex("BuyerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Nethereum.eShop.ApplicationCore.Entities.OrderAggregate.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset?>("ActualEscrowReleaseDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CurrencyValue")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTimeOffset?>("GoodsIssueDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool?>("IsEscrowReleased")
                        .HasColumnType("bit");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("PlannedEscrowReleaseDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("PoItemNumber")
                        .HasColumnType("int");

                    b.Property<int?>("PoItemStatus")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("QuantityAddress")
                        .HasColumnType("nvarchar(43)")
                        .HasMaxLength(43);

                    b.Property<string>("QuantitySymbol")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(50)")
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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApproverAddress")
                        .HasColumnType("nvarchar(43)")
                        .HasMaxLength(43);

                    b.Property<string>("BuyerAddress")
                        .HasColumnType("nvarchar(43)")
                        .HasMaxLength(43);

                    b.Property<string>("BuyerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("BuyerWalletAddress")
                        .HasColumnType("nvarchar(43)")
                        .HasMaxLength(43);

                    b.Property<string>("CurrencyAddress")
                        .HasColumnType("nvarchar(43)")
                        .HasMaxLength(43);

                    b.Property<string>("CurrencySymbol")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("Date")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("Expiry")
                        .HasColumnType("datetimeoffset");

                    b.Property<long?>("PoNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("PoType")
                        .HasColumnType("int");

                    b.Property<string>("SellerId")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TransactionHash")
                        .HasColumnType("nvarchar(67)")
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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CurrencyValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("EscrowReleaseDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("PoItemNumber")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("QuantityAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuantitySymbol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuoteId")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:HiLoSequenceName", "stock_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<int>("CatalogItemId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
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
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("nvarchar(100)")
                                .HasMaxLength(100);

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("nvarchar(90)")
                                .HasMaxLength(90);

                            b1.Property<string>("RecipientName")
                                .IsRequired()
                                .HasColumnType("nvarchar(255)")
                                .HasMaxLength(255);

                            b1.Property<string>("State")
                                .HasColumnType("nvarchar(60)")
                                .HasMaxLength(60);

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("nvarchar(180)")
                                .HasMaxLength(180);

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasColumnType("nvarchar(18)")
                                .HasMaxLength(18);

                            b1.HasKey("BasketId");

                            b1.ToTable("Baskets");

                            b1.WithOwner()
                                .HasForeignKey("BasketId");
                        });

                    b.OwnsOne("Nethereum.eShop.ApplicationCore.Entities.PostalAddress", "ShipTo", b1 =>
                        {
                            b1.Property<int>("BasketId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("nvarchar(100)")
                                .HasMaxLength(100);

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("nvarchar(90)")
                                .HasMaxLength(90);

                            b1.Property<string>("RecipientName")
                                .IsRequired()
                                .HasColumnType("nvarchar(255)")
                                .HasMaxLength(255);

                            b1.Property<string>("State")
                                .HasColumnType("nvarchar(60)")
                                .HasMaxLength(60);

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("nvarchar(180)")
                                .HasMaxLength(180);

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasColumnType("nvarchar(18)")
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
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("nvarchar(100)")
                                .HasMaxLength(100);

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("nvarchar(90)")
                                .HasMaxLength(90);

                            b1.Property<string>("RecipientName")
                                .IsRequired()
                                .HasColumnType("nvarchar(255)")
                                .HasMaxLength(255);

                            b1.Property<string>("State")
                                .HasColumnType("nvarchar(60)")
                                .HasMaxLength(60);

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("nvarchar(180)")
                                .HasMaxLength(180);

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasColumnType("nvarchar(18)")
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
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("nvarchar(100)")
                                .HasMaxLength(100);

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("nvarchar(90)")
                                .HasMaxLength(90);

                            b1.Property<string>("RecipientName")
                                .IsRequired()
                                .HasColumnType("nvarchar(255)")
                                .HasMaxLength(255);

                            b1.Property<string>("State")
                                .HasColumnType("nvarchar(60)")
                                .HasMaxLength(60);

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("nvarchar(180)")
                                .HasMaxLength(180);

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasColumnType("nvarchar(18)")
                                .HasMaxLength(18);

                            b1.HasKey("OrderId");

                            b1.ToTable("Orders");

                            b1.WithOwner()
                                .HasForeignKey("OrderId");
                        });

                    b.OwnsOne("Nethereum.eShop.ApplicationCore.Entities.PostalAddress", "ShipTo", b1 =>
                        {
                            b1.Property<int>("OrderId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("nvarchar(100)")
                                .HasMaxLength(100);

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("nvarchar(90)")
                                .HasMaxLength(90);

                            b1.Property<string>("RecipientName")
                                .IsRequired()
                                .HasColumnType("nvarchar(255)")
                                .HasMaxLength(255);

                            b1.Property<string>("State")
                                .HasColumnType("nvarchar(60)")
                                .HasMaxLength(60);

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("nvarchar(180)")
                                .HasMaxLength(180);

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasColumnType("nvarchar(18)")
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
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("CatalogItemId")
                                .HasColumnType("int");

                            b1.Property<string>("Gtin")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int?>("GtinRegistryId")
                                .HasColumnType("int");

                            b1.Property<string>("PictureUri")
                                .HasColumnType("nvarchar(512)")
                                .HasMaxLength(512);

                            b1.Property<string>("ProductName")
                                .IsRequired()
                                .HasColumnType("nvarchar(50)")
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
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("nvarchar(100)")
                                .HasMaxLength(100);

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("nvarchar(90)")
                                .HasMaxLength(90);

                            b1.Property<string>("RecipientName")
                                .IsRequired()
                                .HasColumnType("nvarchar(255)")
                                .HasMaxLength(255);

                            b1.Property<string>("State")
                                .HasColumnType("nvarchar(60)")
                                .HasMaxLength(60);

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("nvarchar(180)")
                                .HasMaxLength(180);

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasColumnType("nvarchar(18)")
                                .HasMaxLength(18);

                            b1.HasKey("QuoteId");

                            b1.ToTable("Quotes");

                            b1.WithOwner()
                                .HasForeignKey("QuoteId");
                        });

                    b.OwnsOne("Nethereum.eShop.ApplicationCore.Entities.PostalAddress", "ShipTo", b1 =>
                        {
                            b1.Property<int>("QuoteId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("nvarchar(100)")
                                .HasMaxLength(100);

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("nvarchar(90)")
                                .HasMaxLength(90);

                            b1.Property<string>("RecipientName")
                                .IsRequired()
                                .HasColumnType("nvarchar(255)")
                                .HasMaxLength(255);

                            b1.Property<string>("State")
                                .HasColumnType("nvarchar(60)")
                                .HasMaxLength(60);

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("nvarchar(180)")
                                .HasMaxLength(180);

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasColumnType("nvarchar(18)")
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
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("CatalogItemId")
                                .HasColumnType("int");

                            b1.Property<string>("Gtin")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int?>("GtinRegistryId")
                                .HasColumnType("int");

                            b1.Property<string>("PictureUri")
                                .HasColumnType("nvarchar(512)")
                                .HasMaxLength(512);

                            b1.Property<string>("ProductName")
                                .IsRequired()
                                .HasColumnType("nvarchar(50)")
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
