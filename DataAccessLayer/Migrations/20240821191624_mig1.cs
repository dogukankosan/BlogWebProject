using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutDetails1 = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    AboutDetails2 = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    AboutImage1 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    AboutImage2 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CategoryDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoryStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "ContactAbouts",
                columns: table => new
                {
                    ContactAboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IFrameLocation = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactAbouts", x => x.ContactAboutID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ContactMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ContactSubject = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ContactMessage = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "NewsLetters",
                columns: table => new
                {
                    NewsLetterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MailStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsLetters", x => x.NewsLetterID);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    SocialMediaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacebookLink = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    GithubLink = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    GoogleLink = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    InstagramLink = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.SocialMediaID);
                });

            migrationBuilder.CreateTable(
                name: "Writers",
                columns: table => new
                {
                    WriterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WriterName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WriterAbout = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    WriterMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WriterPassword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WriterImage = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    WriterStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writers", x => x.WriterID);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BlogContent = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    BlogSmallImage = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    BlogBigImage = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BlogStatus = table.Column<bool>(type: "bit", nullable: false),
                    CategoryID = table.Column<byte>(type: "tinyint", nullable: false),
                    WriterID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogID);
                    table.ForeignKey(
                        name: "FK_Blogs_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Blogs_Writers_WriterID",
                        column: x => x.WriterID,
                        principalTable: "Writers",
                        principalColumn: "WriterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CommentTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CommentContent = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CommentStatus = table.Column<bool>(type: "bit", nullable: false),
                    BlogID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comments_Blogs_BlogID",
                        column: x => x.BlogID,
                        principalTable: "Blogs",
                        principalColumn: "BlogID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "AboutID", "AboutDetails1", "AboutDetails2", "AboutImage1", "AboutImage2" },
                values: new object[] { 1, "Her konuya hitap eden bloglarımızla bilgi dolu bir yolculuğa çıkın! İlham verici makaleler ve pratik tavsiyelerle dolu sitemizde aradığınız her şeyi bulacaksınız.", "Her yaşa, ilgi alanına ve ihtiyaca yönelik zengin içeriklerle dolu bloglarımız, bilgiye ulaşmanın en keyifli yolunu sunuyor. Gündelik yaşamdan teknolojiye, sağlıktan seyahate kadar geniş yelpazede ele aldığımız konularla, hem öğrenirken hem de eğleneceksiniz. Uzman yazarlarımızın kaleminden çıkan güncel ve özgün makalelerle hayatınıza değer katın. Sitemizde yer alan pratik tavsiyeler, ilham dolu fikirler ve derinlemesine analizlerle bilginin gücünü keşfedin!", "https://img.freepik.com/free-vector/blogging-fun-content-creation-online-streaming-video-blog-young-girl-making-selfie-social-network-sharing-feedback-self-promotion-strategy-vector-isolated-concept-metaphor-illustration_335657-855.jpg", "https://techstory.in/wp-content/uploads/2022/11/Blogging.jpg" });

            migrationBuilder.InsertData(
                table: "ContactAbouts",
                columns: new[] { "ContactAboutID", "Address", "IFrameLocation", "Mail", "Phone" },
                values: new object[] { 1, "Silivri,İstanbul", "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d192502.9383590522!2d28.03599348690269!3d41.07208749327083!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14b53fdbc4bfe901%3A0x6f637ffe39da55b6!2sSilivri%2C%20%C4%B0stanbul!5e0!3m2!1str!2str!4v1724266980119!5m2!1str!2str", "dogukandevp@gmail.com", "905455111134" });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "SocialMediaID", "FacebookLink", "GithubLink", "GoogleLink", "InstagramLink" },
                values: new object[] { 1, "https://tr-tr.facebook.com/people/Do%C4%9Fukan-Ko%C5%9Fan/pfbid0QFcRA34xX6CGRSAMhyekwT7dbEsvuqxbsUDXK6kjrwM3BP7HWKfNuB7vAPmb1Avfl/", "https://github.com/dogukankosan", "dogukandevp@gmail.com", "https://www.instagram.com/dogukankosan/" });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryID",
                table: "Blogs",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_WriterID",
                table: "Blogs",
                column: "WriterID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogID",
                table: "Comments",
                column: "BlogID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ContactAbouts");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "NewsLetters");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Writers");
        }
    }
}
