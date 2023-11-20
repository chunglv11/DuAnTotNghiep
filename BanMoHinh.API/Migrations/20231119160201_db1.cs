﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BanMoHinh.API.Migrations
{
<<<<<<<< HEAD:BanMoHinh.API/Migrations/20231113161343_13112023.cs
    public partial class _13112023 : Migration
========
    public partial class db1 : Migration
>>>>>>>> hung:BanMoHinh.API/Migrations/20231119160201_db1.cs
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ColorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ColorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ColorId);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaterialName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rank",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PointsMin = table.Column<int>(type: "int", nullable: true),
                    PoinsMax = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SizeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Width = table.Column<double>(type: "float", nullable: true),
                    Height = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "voucherstatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_voucherstatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VoucherType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoucherType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvailableQuantity = table.Column<int>(type: "int", nullable: true),
                    Create_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Update_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Long_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Product_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Material",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Points = table.Column<int>(type: "int", nullable: true),
                    RankId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Rank_RankId",
                        column: x => x.RankId,
                        principalTable: "Rank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Voucher",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VoucherTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    VoucherStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: true),
                    Minimum_order_value = table.Column<int>(type: "int", nullable: true),
                    Create_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Start_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voucher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Voucher_voucherstatus_VoucherStatusId",
                        column: x => x.VoucherStatusId,
                        principalTable: "voucherstatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Voucher_VoucherType_VoucherTypeId",
                        column: x => x.VoucherTypeId,
                        principalTable: "VoucherType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SizeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ColorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PriceSale = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Create_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Update_At = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDetail_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "ColorId");
                    table.ForeignKey(
                        name: "FK_ProductDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductDetail_Size_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Size",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Adresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ward = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adresses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cart_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Tittle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TittleImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WishList",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishList_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WishList_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrderStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PaymentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    VoucherId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrderCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipientAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipientPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalAmout = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    VoucherValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalAmoutAfterApplyingVoucher = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ShippingFee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Create_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ship_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Payment_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Delivery_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Order_OrderStatus_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Order_Payment_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Order_Voucher_VoucherId",
                        column: x => x.VoucherId,
                        principalTable: "Voucher",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VoucherDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VoucherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoucherDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoucherDetails_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VoucherDetails_Voucher_VoucherId",
                        column: x => x.VoucherId,
                        principalTable: "Voucher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VoucherUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VoucherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoucherUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoucherUser_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VoucherUser_Voucher_VoucherId",
                        column: x => x.VoucherId,
                        principalTable: "Voucher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImage_ProductDetail_ProductDetailId",
                        column: x => x.ProductDetailId,
                        principalTable: "ProductDetail",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CartId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductDetail_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItem_Cart_CartId",
                        column: x => x.CartId,
                        principalTable: "Cart",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CartItem_ProductDetail_ProductDetail_ID",
                        column: x => x.ProductDetail_ID,
                        principalTable: "ProductDetail",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderItem_ProductDetail_ProductDetailId",
                        column: x => x.ProductDetailId,
                        principalTable: "ProductDetail",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rate_OrderItem_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
<<<<<<<< HEAD:BanMoHinh.API/Migrations/20231113161343_13112023.cs
                    { new Guid("59a491f2-2083-47ce-91f0-6cac2a2eb61a"), "42e407b9-7426-49a3-a9e3-01ec2d32d010", "Admin", "ADMIN" },
                    { new Guid("d462c50b-e955-47f2-a70b-2291afaee9fd"), "3570d24c-5cd1-4e20-953a-01b5f0c90253", "User", "USER" },
                    { new Guid("febef870-6173-4204-804e-ac80720c0c97"), "b34751f3-f4bb-499a-b894-965ece1ca8a5", "Guest", "GUEST" }
========
                    { new Guid("27ee3f10-62d4-4d69-a9c1-9af433e03873"), "3ff385e0-bcfd-4e4a-976e-16dfc62c652e", "User", "USER" },
                    { new Guid("9e5bc4ff-6a9a-47cb-9588-ab844b612a21"), "7b157af5-bf58-4e14-80cc-c761593fa7ec", "Guest", "GUEST" },
                    { new Guid("a5f923b7-2f22-4a01-bed8-6cd1c3a3a21a"), "8a351fba-caea-4985-ae82-d7716b214799", "Admin", "ADMIN" }
>>>>>>>> hung:BanMoHinh.API/Migrations/20231119160201_db1.cs
                });

            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "Id", "BrandName" },
                values: new object[,]
                {
<<<<<<<< HEAD:BanMoHinh.API/Migrations/20231113161343_13112023.cs
                    { new Guid("1aa587aa-e3d0-48a0-b463-754ef3f701bc"), "Brand 2" },
                    { new Guid("60bbb486-60ae-4322-a9df-7a62979bd717"), "Brand 4" },
                    { new Guid("9b490f96-e42a-42c8-a8fc-1eff7c30e0f4"), "Brand 1" },
                    { new Guid("d4efabe6-7006-4d0b-b8f5-285983e42dd4"), "Brand 3" },
                    { new Guid("e52d6f07-e554-4a74-bf55-6197aa41678e"), "Brand 5" }
========
                    { new Guid("0ac20c8b-46fa-4378-8a13-852f8062f377"), "Brand 3" },
                    { new Guid("5b26d63d-4144-4ef4-8031-646d661b4cd7"), "Brand 2" },
                    { new Guid("77b3ddb9-3679-46ad-9381-18b9f74dd241"), "Brand 5" },
                    { new Guid("99cf50e4-591b-407c-b517-4b9e681a6117"), "Brand 4" },
                    { new Guid("9b3f0c0a-290e-47c7-b37a-61d3bc2eefe9"), "Brand 1" }
>>>>>>>> hung:BanMoHinh.API/Migrations/20231119160201_db1.cs
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
<<<<<<<< HEAD:BanMoHinh.API/Migrations/20231113161343_13112023.cs
                    { new Guid("2b67a9b4-75db-41de-8d25-8cd967191331"), "Category 3" },
                    { new Guid("362c812f-5790-4ec0-bb05-6b6ccae7fd3f"), "Category 2" },
                    { new Guid("4218c663-a4a0-41d9-9803-a81b9516503f"), "Category 1" },
                    { new Guid("9f767ea1-f374-4540-aea6-774cf48ef6f0"), "Category 5" },
                    { new Guid("bb916f5c-c51b-4220-b4ef-a910813ed87c"), "Category 4" }
========
                    { new Guid("1563d6dd-8e83-4d64-aaeb-f48bcf4d4f22"), "Category 4" },
                    { new Guid("51d2f177-03b8-4b7f-8e2a-e5a00488efec"), "Category 5" },
                    { new Guid("a35536b0-989b-48d3-afbd-366c5f563658"), "Category 1" },
                    { new Guid("e5233bd7-b2af-4df3-9d5a-2a148040da3d"), "Category 2" },
                    { new Guid("fc9bceb2-0605-49ff-8439-9b3856e0be61"), "Category 3" }
>>>>>>>> hung:BanMoHinh.API/Migrations/20231119160201_db1.cs
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "ColorId", "ColorCode", "ColorName" },
                values: new object[,]
                {
<<<<<<<< HEAD:BanMoHinh.API/Migrations/20231113161343_13112023.cs
                    { new Guid("062371a8-4dc3-4fea-8fb7-66861e21d0e3"), "#808080", "Xám" },
                    { new Guid("122ef464-a2f1-462f-af8a-ebb26ffd84e8"), "#FFC0CB", "Hồng" },
                    { new Guid("23e1d459-9174-4315-9b6c-a6c5010206e5"), "#0000FF", "Xanh dương" },
                    { new Guid("4143ab44-e779-4c17-84d5-52eac5e6f7aa"), "#FFFFFF", "Trắng" },
                    { new Guid("41e27708-75fa-4fb0-bf81-98cb07a19bdd"), "#00BFFF", "Xanh da trời" },
                    { new Guid("66f095a6-bdae-472f-90d1-161755d1af5d"), "#FFDAB9", "Hồng phấn" },
                    { new Guid("6f71c8e8-3bb7-4912-9744-ee036b456fe0"), "#C0C0C0", "Bạc" },
                    { new Guid("7fd0dd1f-e137-4089-8a7e-acf7712971d5"), "#000080", "Xanh lam" },
                    { new Guid("8e0be780-c8b0-4a34-a13b-a96e7599d0f4"), "#A52A2A", "Nâu" },
                    { new Guid("a93fbf66-d85b-411c-8a75-aca94a15d07c"), "#FFA500", "Cam" },
                    { new Guid("b6c7763f-ed84-494e-a337-c89ba1ee8ce9"), "#C0C0C0", "Xám tro" },
                    { new Guid("bff32bbc-bc15-4ac5-9bca-62aef0772560"), "#FFFF00", "Vàng" },
                    { new Guid("c0a6c036-eda1-465e-99c8-4e818f55e617"), "#000000", "Đen" },
                    { new Guid("d587e0b6-203d-48be-ae0c-bb687e8eb3a4"), "#800080", "Tím" },
                    { new Guid("e1252c19-c29a-477f-880f-6920a1b6a545"), "#00FF00", "Xanh lá cây" },
                    { new Guid("fa6c70c1-dd79-461f-837d-8803cd28a098"), "#FF0000", "Đỏ" }
========
                    { new Guid("069ba292-8fec-4483-b8da-5d5e1e6ca1d8"), "#00FF00", "Xanh lá cây" },
                    { new Guid("119ce713-e16e-4c23-b687-f84e4b7110e4"), "#FF0000", "Đỏ" },
                    { new Guid("1a844407-f341-4720-a163-40bcc652ebeb"), "#FFC0CB", "Hồng" },
                    { new Guid("1b05e7c4-3181-41c2-a9e8-84b5c676b305"), "#A52A2A", "Nâu" },
                    { new Guid("27695ab5-2aae-4dcf-acb6-c4102f1e4265"), "#800080", "Tím" },
                    { new Guid("3734e267-efb8-4409-a6b3-adaf54e5f93f"), "#C0C0C0", "Bạc" },
                    { new Guid("5959a9e5-0278-4d63-8fc3-8b557984afde"), "#FFFFFF", "Trắng" },
                    { new Guid("752125bb-c598-4927-b1a4-1ca39c22c258"), "#000080", "Xanh lam" },
                    { new Guid("80538c0a-014a-4b18-b868-3f4622afb490"), "#000000", "Đen" },
                    { new Guid("8124a5cb-f808-45dd-80aa-d75cf303889c"), "#00BFFF", "Xanh da trời" },
                    { new Guid("a14ae2eb-6941-4765-9f83-b00e916a080c"), "#FFFF00", "Vàng" },
                    { new Guid("b84d08b7-fb3f-4aa9-afb8-841304e96f8a"), "#0000FF", "Xanh dương" },
                    { new Guid("c677db30-379b-4352-88cb-0b32b6ad0b4b"), "#FFA500", "Cam" },
                    { new Guid("d24f76ff-c03e-47de-a1f8-7ff17157417d"), "#FFDAB9", "Hồng phấn" },
                    { new Guid("e49199ad-c3f7-439f-9385-8e127b815fef"), "#808080", "Xám" },
                    { new Guid("f6b77d2b-13f3-4c1c-8093-d213549c9669"), "#C0C0C0", "Xám tro" }
>>>>>>>> hung:BanMoHinh.API/Migrations/20231119160201_db1.cs
                });

            migrationBuilder.InsertData(
                table: "Material",
                columns: new[] { "Id", "MaterialName" },
                values: new object[,]
                {
<<<<<<<< HEAD:BanMoHinh.API/Migrations/20231113161343_13112023.cs
                    { new Guid("09420567-67ea-4065-be97-12a4cc52d109"), "Gỗ" },
                    { new Guid("18a10019-5a6a-45a3-8b7f-962efff912e0"), "Nhựa pvc" },
                    { new Guid("827fa1bd-bc38-44a7-97d5-c77581080320"), "Sắt" }
========
                    { new Guid("9933d484-b7d6-469b-b5b4-dcc93029b423"), "Gỗ" },
                    { new Guid("b0198cb6-0217-4696-9b6a-4b64c56346ec"), "Sắt" },
                    { new Guid("ba265fa6-2b4d-4fc2-b2df-f0f427886add"), "Nhựa pvc" }
>>>>>>>> hung:BanMoHinh.API/Migrations/20231119160201_db1.cs
                });

            migrationBuilder.InsertData(
                table: "OrderStatus",
                columns: new[] { "Id", "OrderStatusName" },
                values: new object[,]
                {
<<<<<<<< HEAD:BanMoHinh.API/Migrations/20231113161343_13112023.cs
                    { new Guid("1d4f0bfb-e2a7-4195-8c11-3fa351caf65c"), "Giao hàng không thành công" },
                    { new Guid("2875d97a-c8de-4dc5-8857-35ec1aee8fd8"), "Yêu cầu trả hàng" },
                    { new Guid("304e1a4d-f53c-4e84-bef9-2f3ef64d383a"), "Đang giao hàng" },
                    { new Guid("3a125bc3-9f3d-4306-937a-c486a0c3c448"), "Hủy đơn" },
                    { new Guid("4db39967-fd9a-4715-9201-0ed5025279ed"), "Chờ lấy hàng" },
                    { new Guid("7095e5e4-7b8e-4530-85d9-b77c4776c962"), "Đang được xử lý" },
                    { new Guid("c5ee777b-911e-442c-9efc-f2aaa73b4190"), "Chấp nhận trả hàng" },
                    { new Guid("d8bf59ed-2793-46a7-ac9e-a9a09c78673b"), "Giao hàng thành công" }
========
                    { new Guid("19d6a5dc-736d-4c0a-88a4-90a97ad6a2fd"), "Giao hàng thành công" },
                    { new Guid("478550b4-a57f-4f02-a14a-223922c4c8f5"), "Đang được xử lý" },
                    { new Guid("519eb4d6-6092-4c08-b5ef-430d27f760c2"), "Giao hàng không thành công" },
                    { new Guid("7d3c634c-324a-4b80-9373-f942921b64b4"), "Chờ lấy hàng" },
                    { new Guid("988ad1b7-3c57-4e2f-8657-02d089926c27"), "Chấp nhận trả hàng" },
                    { new Guid("c0a8f8c1-e468-4727-9533-2f73656baa21"), "Đang giao hàng" },
                    { new Guid("eb4533ab-e01e-45ad-80ea-10a7e240d525"), "Hủy đơn" },
                    { new Guid("ecfce80e-b992-422d-8c92-61d728d4503a"), "Yêu cầu trả hàng" }
>>>>>>>> hung:BanMoHinh.API/Migrations/20231119160201_db1.cs
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "Id", "PaymentName" },
                values: new object[,]
                {
<<<<<<<< HEAD:BanMoHinh.API/Migrations/20231113161343_13112023.cs
                    { new Guid("f517be0a-f654-4f76-bc86-624446099c49"), "Thanh toán Online" },
                    { new Guid("f5a8622c-775b-4b94-ab8e-c13430063d19"), "Thanh toán khi nhận hàng" }
========
                    { new Guid("a6f79672-f0de-42d8-ae7a-1bc7f5595de7"), "Thanh toán Online" },
                    { new Guid("bc0ff280-df20-4ce2-a809-30f2c3caaa67"), "Thanh toán khi nhận hàng" }
>>>>>>>> hung:BanMoHinh.API/Migrations/20231119160201_db1.cs
                });

            migrationBuilder.InsertData(
                table: "Rank",
                columns: new[] { "Id", "Description", "Name", "PoinsMax", "PointsMin" },
                values: new object[,]
                {
<<<<<<<< HEAD:BanMoHinh.API/Migrations/20231113161343_13112023.cs
                    { new Guid("671c5ec5-c6e6-424c-817e-b1b4a57a3fda"), null, "Bạc", 1000000, 0 },
                    { new Guid("8056df54-125c-4350-bf09-e0d239539920"), null, "Vàng", 3000000, 1000001 },
                    { new Guid("f90a507b-1494-4cb6-aadd-28f41be7fa3e"), null, "Kim Cương", 10000000, 3000001 }
========
                    { new Guid("2a87303c-ccac-4d8d-aefc-dd13b1e6c0dc"), null, "Vàng", 3000000, 1000001 },
                    { new Guid("86fc745d-73eb-4a97-8a77-166ad22b3041"), null, "Kim Cương", 10000000, 3000001 },
                    { new Guid("90a580c4-cdf3-4cf2-9b73-139083043f4c"), null, "Bạc", 1000000, 0 }
>>>>>>>> hung:BanMoHinh.API/Migrations/20231119160201_db1.cs
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "Height", "SizeName", "Width" },
                values: new object[,]
                {
<<<<<<<< HEAD:BanMoHinh.API/Migrations/20231113161343_13112023.cs
                    { new Guid("0d4d955e-ccd3-4080-af4f-156dd7ae4c57"), 30.0, "Size 5", 30.0 },
                    { new Guid("1b25d0bc-1402-4bf9-bacb-b2c05d2e11f5"), 30.0, "Size 4", 30.0 },
                    { new Guid("5d6a61b7-e49d-43bf-96fd-0ba1314c01af"), 30.0, "Size 2", 30.0 },
                    { new Guid("db7b2b87-54c5-4bdc-bfff-ac0117a49a3b"), 30.0, "Size 3", 30.0 },
                    { new Guid("fac89534-e4dc-460a-b96f-55938b71460e"), 30.0, "Size 1", 30.0 }
========
                    { new Guid("1b6b6914-b557-4aeb-820e-4d397b2cec44"), 30.0, "Size 4", 30.0 },
                    { new Guid("33c9916d-770f-47f2-8ace-85fe947af28b"), 30.0, "Size 1", 30.0 },
                    { new Guid("37973cf8-9710-4b4c-8a91-dddafc550575"), 30.0, "Size 2", 30.0 },
                    { new Guid("933bed4a-cefc-44e4-b2d9-8bc3ffd138ae"), 30.0, "Size 5", 30.0 },
                    { new Guid("e24bb620-2afd-4d73-8104-d2bad0cb0bf1"), 30.0, "Size 3", 30.0 }
>>>>>>>> hung:BanMoHinh.API/Migrations/20231119160201_db1.cs
                });

            migrationBuilder.InsertData(
                table: "VoucherType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
<<<<<<<< HEAD:BanMoHinh.API/Migrations/20231113161343_13112023.cs
                    { new Guid("470f6999-4f6e-4766-868e-b38d69645776"), "Khánh hàng" },
                    { new Guid("8101a90d-c95b-44ad-9e01-8ae99dad5e0c"), "Sản phẩm" }
========
                    { new Guid("1f0baa17-8126-41a4-9139-7580e1dbe9d0"), "Khánh hàng" },
                    { new Guid("c28b09c1-1cf2-443b-99f3-d6dcd8f4b3e1"), "Sản phẩm" }
>>>>>>>> hung:BanMoHinh.API/Migrations/20231119160201_db1.cs
                });

            migrationBuilder.InsertData(
                table: "voucherstatus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
<<<<<<<< HEAD:BanMoHinh.API/Migrations/20231113161343_13112023.cs
                    { new Guid("a70515ea-b96a-4cd4-93be-822c2c2bf4c6"), "Expired" },
                    { new Guid("a7e90e6d-3e7d-4462-baad-4388a3cc5ac1"), "Active" },
                    { new Guid("be05dee1-4570-427f-a20a-19fcabfa98dd"), "Used" }
========
                    { new Guid("0d0f2eb4-5326-47d4-8719-3a9ffc9dd964"), "Active" },
                    { new Guid("608c376d-119d-4225-a2e6-075c6a1269b6"), "Expired" },
                    { new Guid("de9c8fb5-fb47-47d8-8d52-310f2f3450c9"), "Used" }
>>>>>>>> hung:BanMoHinh.API/Migrations/20231119160201_db1.cs
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_UserId",
                table: "Adresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RankId",
                table: "AspNetUsers",
                column: "RankId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserId",
                table: "Cart",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_CartId",
                table: "CartItem",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_ProductDetail_ID",
                table: "CartItem",
                column: "ProductDetail_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderStatusId",
                table: "Order",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PaymentId",
                table: "Order",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_VoucherId",
                table: "Order",
                column: "VoucherId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductDetailId",
                table: "OrderItem",
                column: "ProductDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_BrandId",
                table: "Product",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_MaterialId",
                table: "Product",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetail_ColorId",
                table: "ProductDetail",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetail_ProductId",
                table: "ProductDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetail_SizeId",
                table: "ProductDetail",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_ProductDetailId",
                table: "ProductImage",
                column: "ProductDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Rate_OrderItemId",
                table: "Rate",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Voucher_VoucherStatusId",
                table: "Voucher",
                column: "VoucherStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Voucher_VoucherTypeId",
                table: "Voucher",
                column: "VoucherTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VoucherDetails_ProductId",
                table: "VoucherDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_VoucherDetails_VoucherId",
                table: "VoucherDetails",
                column: "VoucherId");

            migrationBuilder.CreateIndex(
                name: "IX_VoucherUser_UserId",
                table: "VoucherUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VoucherUser_VoucherId",
                table: "VoucherUser",
                column: "VoucherId");

            migrationBuilder.CreateIndex(
                name: "IX_WishList_ProductId",
                table: "WishList",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WishList_UserId",
                table: "WishList",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adresses");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "ProductImage");

            migrationBuilder.DropTable(
                name: "Rate");

            migrationBuilder.DropTable(
                name: "VoucherDetails");

            migrationBuilder.DropTable(
                name: "VoucherUser");

            migrationBuilder.DropTable(
                name: "WishList");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "ProductDetail");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "OrderStatus");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Voucher");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropTable(
                name: "Rank");

            migrationBuilder.DropTable(
                name: "voucherstatus");

            migrationBuilder.DropTable(
                name: "VoucherType");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Material");
        }
    }
}
