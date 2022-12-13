using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoonfactoryPage.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAcmicpcschema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcmicpcProblems",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcmicpcProblems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AcmicpcProblemPublishs",
                columns: table => new
                {
                    PublishNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProblemId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Result = table.Column<byte>(type: "tinyint", nullable: true),
                    PublishAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcmicpcProblemPublishs", x => x.PublishNo);
                    table.ForeignKey(
                        name: "FK_AcmicpcProblemPublishs_AcmicpcProblems_ProblemId",
                        column: x => x.ProblemId,
                        principalTable: "AcmicpcProblems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecommendProblems",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecommendProblems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecommendProblems_AcmicpcProblems_Id",
                        column: x => x.Id,
                        principalTable: "AcmicpcProblems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcmicpcProblemPublishs_ProblemId",
                table: "AcmicpcProblemPublishs",
                column: "ProblemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcmicpcProblemPublishs");

            migrationBuilder.DropTable(
                name: "RecommendProblems");

            migrationBuilder.DropTable(
                name: "AcmicpcProblems");
        }
    }
}
