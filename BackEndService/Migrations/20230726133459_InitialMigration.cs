using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackEndService.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Author = table.Column<string>(type: "text", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
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
                });

            migrationBuilder.CreateTable(
                name: "Librarian",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
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
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    Faculty = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookBoughtBooks",
                columns: table => new
                {
                    BoughtBooksId = table.Column<Guid>(type: "uuid", nullable: false),
                    booksId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookBoughtBooks", x => new { x.BoughtBooksId, x.booksId });
                    table.ForeignKey(
                        name: "FK_BookBoughtBooks_Books_booksId",
                        column: x => x.booksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookBoughtBooks_BoughtBooks_BoughtBooksId",
                        column: x => x.BoughtBooksId,
                        principalTable: "BoughtBooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "BoughtBooksStudent",
                columns: table => new
                {
                    BoughtBooksId = table.Column<Guid>(type: "uuid", nullable: false),
                    studentsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoughtBooksStudent", x => new { x.BoughtBooksId, x.studentsId });
                    table.ForeignKey(
                        name: "FK_BoughtBooksStudent_BoughtBooks_BoughtBooksId",
                        column: x => x.BoughtBooksId,
                        principalTable: "BoughtBooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoughtBooksStudent_Students_studentsId",
                        column: x => x.studentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Description", "Price", "Quantity", "Title" },
                values: new object[,]
                {
                    { new Guid("9745f08c-4cbc-4888-a881-c890842e0ead"), "Gustav Flaubert", "Lorem ipsum", 30.0, 20, "Madame Bovary" },
                    { new Guid("a09b59e7-240c-4a28-919f-8a19dfc2a86e"), "Lev Tolstoy", "Lorem ipsum", 23.0, 30, "Anna Karenina" },
                    { new Guid("e25020c2-9175-4ec4-8cb8-dfa0e11686f8"), "Lev Tolstoy", "Lorem ipsum", 40.0, 12, "War and Peace" }
                });

            migrationBuilder.InsertData(
                table: "Librarian",
                columns: new[] { "Id", "FirstName", "LastName", "Password", "PhoneNumber", "UserName" },
                values: new object[,]
                {
                    { new Guid("570fe434-6f20-44e2-83a8-84dec81b8108"), "Judit", "Polgar", "Pass123", "998973290312", "judpl" },
                    { new Guid("d1707dfc-85f9-4039-ac3a-0d1358554e46"), "Izabella", "Dickson", "Izason11", "998913845940", "Iza" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Faculty", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { new Guid("2ebec012-d020-43c0-b621-6092fc700312"), 3, "Dominik", "Toretto", "888892834769" },
                    { new Guid("7fcf0586-0358-4638-91cd-147b1a014b05"), 2, "Pirc", "Roman", "998992349012" },
                    { new Guid("e8ba3b0b-9481-4ef4-883f-6df822b55884"), 5, "Paul", "Walker", "9982345678" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookBoughtBooks_booksId",
                table: "BookBoughtBooks",
                column: "booksId");

            migrationBuilder.CreateIndex(
                name: "IX_BookStudents_BookId",
                table: "BookStudents",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookStudents_StudentId",
                table: "BookStudents",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_BoughtBooksStudent_studentsId",
                table: "BoughtBooksStudent",
                column: "studentsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookBoughtBooks");

            migrationBuilder.DropTable(
                name: "BookStudents");

            migrationBuilder.DropTable(
                name: "BoughtBooksStudent");

            migrationBuilder.DropTable(
                name: "Librarian");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "BoughtBooks");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
