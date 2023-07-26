using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEndService.Migrations
{
    /// <inheritdoc />
    public partial class EditedSomeRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookBoughtBooks");

            migrationBuilder.DropTable(
                name: "BoughtBooksStudent");

            migrationBuilder.CreateIndex(
                name: "IX_BoughtBooks_BookId",
                table: "BoughtBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BoughtBooks_StudentId",
                table: "BoughtBooks",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_BoughtBooks_Books_BookId",
                table: "BoughtBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BoughtBooks_Students_StudentId",
                table: "BoughtBooks",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BoughtBooks_Books_BookId",
                table: "BoughtBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_BoughtBooks_Students_StudentId",
                table: "BoughtBooks");

            migrationBuilder.DropIndex(
                name: "IX_BoughtBooks_BookId",
                table: "BoughtBooks");

            migrationBuilder.DropIndex(
                name: "IX_BoughtBooks_StudentId",
                table: "BoughtBooks");

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

            migrationBuilder.CreateIndex(
                name: "IX_BookBoughtBooks_booksId",
                table: "BookBoughtBooks",
                column: "booksId");

            migrationBuilder.CreateIndex(
                name: "IX_BoughtBooksStudent_studentsId",
                table: "BoughtBooksStudent",
                column: "studentsId");
        }
    }
}
