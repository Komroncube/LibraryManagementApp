using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace managementcheck.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Author = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Librarian",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Librarian", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    Faculty = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookStudents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    StudentId = table.Column<Guid>(type: "uuid", nullable: false),
                    BookId = table.Column<Guid>(type: "uuid", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookStudents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookStudents_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookStudents_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BoughtBooks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    StudentId = table.Column<Guid>(type: "uuid", nullable: false),
                    BookId = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    BoughtTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoughtBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoughtBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoughtBooks_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Description", "Price", "Quantity", "Title" },
                values: new object[,]
                {
                    { new Guid("49eb1f21-cc89-427a-9611-feb264e4055a"), "Lev Tolstoy", "Lorem ipsum", 23.0, 30, "Anna Karenina" },
                    { new Guid("e6267aaa-a321-43b0-a021-779789489b8f"), "Gustav Flaubert", "Lorem ipsum", 30.0, 20, "Madame Bovary" }
                });

            migrationBuilder.InsertData(
                table: "Librarian",
                columns: new[] { "Id", "FirstName", "LastName", "Password", "PhoneNumber", "UserName" },
                values: new object[,]
                {
                    { new Guid("cb2633d5-b064-4a24-b193-bc95fc702595"), "Judit", "Polgar", "Pass123", "998973290312", "judpl" },
                    { new Guid("d67b3d81-b3c7-499e-b026-c48af4e039f5"), "Izabella", "Dickson", "Izason11", "998913845940", "Iza" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Faculty", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("8b1642e5-43fc-443c-9bbf-afbe7d502bd4"), 3, "Pirc", "Roman", "998992349012" },
                    { new Guid("92bb0fa8-4b24-4f68-993e-d8a3cdd70e9a"), 6, "Paul", "Walker", "9982345678" },
                    { new Guid("a15d5783-4e91-4d41-bb77-ac603a08ac80"), 4, "Dominik", "Toretto", "888892834769" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookStudents_BookId",
                table: "BookStudents",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookStudents_StudentId",
                table: "BookStudents",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_BoughtBooks_BookId",
                table: "BoughtBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BoughtBooks_StudentId",
                table: "BoughtBooks",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookStudents");

            migrationBuilder.DropTable(
                name: "BoughtBooks");

            migrationBuilder.DropTable(
                name: "Librarian");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
