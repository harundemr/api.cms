using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.cms.Migrations
{
    /// <inheritdoc />
    public partial class migration_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Logo1",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Logo2",
                table: "Companies");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Links",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "Links",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ColorClass",
                table: "Links",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Links",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IconName",
                table: "Links",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Links",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Links",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Slogan",
                table: "Companies",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Companies",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Companies",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Companies",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Companies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GalleriesId",
                table: "Companies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Logo1Id",
                table: "Companies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Logo2Id",
                table: "Companies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatisticsId",
                table: "Companies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Companies",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Companies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title1 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Title2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ColorClass = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Banners_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorClass = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sections_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    TotalPrice = table.Column<float>(type: "real", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Feature1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Feature2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Feature3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Feature4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Feature5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Feature6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ButtonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Key1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Value1 = table.Column<int>(type: "int", nullable: true),
                    IconName1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Key2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Value2 = table.Column<int>(type: "int", nullable: true),
                    IconName2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Key3 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Value3 = table.Column<int>(type: "int", nullable: true),
                    IconName3 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Key4 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Value4 = table.Column<int>(type: "int", nullable: true),
                    IconName4 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ColorClass = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BannerId = table.Column<int>(type: "int", nullable: true),
                    GalleryId = table.Column<int>(type: "int", nullable: true),
                    NewsId = table.Column<int>(type: "int", nullable: true),
                    SectionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Banners_BannerId",
                        column: x => x.BannerId,
                        principalTable: "Banners",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Images_Galleries_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "Galleries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Images_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Images_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Referances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Referances_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Referances_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_GalleriesId",
                table: "Companies",
                column: "GalleriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_Logo1Id",
                table: "Companies",
                column: "Logo1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_Logo2Id",
                table: "Companies",
                column: "Logo2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_StatisticsId",
                table: "Companies",
                column: "StatisticsId");

            migrationBuilder.CreateIndex(
                name: "IX_Banners_CompanyId",
                table: "Banners",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_BannerId",
                table: "Images",
                column: "BannerId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_GalleryId",
                table: "Images",
                column: "GalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_NewsId",
                table: "Images",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_SectionId",
                table: "Images",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_News_CompanyId",
                table: "News",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Referances_CompanyId",
                table: "Referances",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Referances_ImageId",
                table: "Referances",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_CompanyId",
                table: "Sections",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_CompanyId",
                table: "Services",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Galleries_GalleriesId",
                table: "Companies",
                column: "GalleriesId",
                principalTable: "Galleries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Images_Logo1Id",
                table: "Companies",
                column: "Logo1Id",
                principalTable: "Images",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Images_Logo2Id",
                table: "Companies",
                column: "Logo2Id",
                principalTable: "Images",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Statistics_StatisticsId",
                table: "Companies",
                column: "StatisticsId",
                principalTable: "Statistics",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Galleries_GalleriesId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Images_Logo1Id",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Images_Logo2Id",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Statistics_StatisticsId",
                table: "Companies");

            migrationBuilder.DropTable(
                name: "Referances");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "Galleries");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Companies_GalleriesId",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_Logo1Id",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_Logo2Id",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_StatisticsId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ColorClass",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "IconName",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "GalleriesId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Logo1Id",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Logo2Id",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "StatisticsId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Companies");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Links",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400);

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "Links",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Slogan",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Logo1",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Logo2",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
