using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Quiz_WebApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrectAnswer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                });

            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    QuizId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<int>(type: "int", nullable: false),
                    QuizDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.QuizId);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    OptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OptionText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.OptionId);
                    table.ForeignKey(
                        name: "FK_Options_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionId", "CorrectAnswer", "QuestionText" },
                values: new object[,]
                {
                    { 1, 4, "The Olympic Flame, was, for the first time, ceremonially lighted and burnt in a giant torch at the entrance of the stadium at" },
                    { 18, 72, "Exposure to sunlight helps a person improve his health because" },
                    { 17, 68, "Galileo was an Italian astronomer who" },
                    { 16, 61, "First human heart transplant operation conducted by Dr. Christiaan Barnard on Louis Washkansky, was conducted in" },
                    { 15, 57, "Epsom (England) is the place associated with" },
                    { 14, 55, "India has largest deposits of ____ in the world." },
                    { 13, 49, "ICAO stands for" },
                    { 12, 45, "In which year of First World War Germany declared war on Russia and France?" },
                    { 11, 42, "Hitler party which came into power in 1933 is known as" },
                    { 10, 40, "For which of the following disciplines is Nobel Prize awarded?" },
                    { 9, 34, "Eritrea, which became the 182nd member of the UN in 1993, is in the continent of" },
                    { 8, 30, "Entomology is the science that studies" },
                    { 7, 25, "Grand Central Terminal, Park Avenue, New York is the world's" },
                    { 6, 24, "The purpose of United Nations Fund for Population Activities (UNFPA) is" },
                    { 5, 18, "The number of already named bones in the human skeleton is" },
                    { 4, 13, "The Scottish bacteriologist who discovered penicillin was" },
                    { 3, 11, "The reaction which converts sugar solution into alcohol is an example of" },
                    { 2, 8, "The Olympic Flame symbolises" },
                    { 19, 73, "Guarantee to an exporter that the importer of his goods will pay immediately for the goods ordered by him, is known as" },
                    { 20, 77, "Friction can be reduced by changing from" }
                });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "OptionId", "OptionText", "QuestionId" },
                values: new object[,]
                {
                    { 1, "Athens Games (1896)", 1 },
                    { 58, "Polo", 15 },
                    { 57, "Horse racing", 15 },
                    { 56, "None of the above", 14 },
                    { 55, "mica", 14 },
                    { 54, "copper", 14 },
                    { 53, "gold", 14 },
                    { 52, "None of the above", 13 },
                    { 59, "Shooting", 15 },
                    { 51, "Institute of Company of Accounts Organization", 13 },
                    { 49, "International Civil Aviation Organization", 13 },
                    { 48, "1917", 12 },
                    { 47, "1916", 12 },
                    { 46, "1915", 12 },
                    { 45, "1914", 12 },
                    { 44, "Democratic Party", 11 },
                    { 43, "Ku-Klux-Klan", 11 },
                    { 50, "Indian Corporation of Agriculture Organization", 13 },
                    { 42, "Nazi Party", 11 },
                    { 60, "Snooker", 15 },
                    { 62, "1968", 16 },
                    { 78, "rolling to sliding", 20 },
                    { 77, "sliding to rolling", 20 },
                    { 76, "None of the above", 19 },
                    { 75, "inflation", 19 },
                    { 74, "laissezfaire", 19 },
                    { 73, "Letter of Credit (L/C)", 19 },
                    { 72, "the ultraviolet rays convert skin oil into Vitamin D", 18 },
                    { 61, "1967", 16 },
                    { 71, "the pigment cells in the skin get stimulated and produce a healthy tan", 18 },
                    { 69, "the infrared light kills bacteria in the body", 18 },
                    { 68, "All of the above", 17 },
                    { 67, "discovered that the movement of pendulum produces a regular time measurement", 17 },
                    { 66, "discovered four satellites of Jupiter", 17 },
                    { 65, "developed the telescope", 17 },
                    { 64, "1922", 16 },
                    { 63, "1958", 16 },
                    { 70, "resistance power increases", 18 },
                    { 41, "Labour Party", 11 },
                    { 40, "All of the above", 10 },
                    { 39, "Literature, Peace and Economics", 10 },
                    { 17, "200", 5 }
                });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "OptionId", "OptionText", "QuestionId" },
                values: new object[,]
                {
                    { 16, "Aryabhatta", 4 },
                    { 15, "Archimeder", 4 },
                    { 14, "Albert Einstein", 4 },
                    { 13, "Alexander Fleming", 4 },
                    { 12, "hydrolysis", 3 },
                    { 11, "fermentation", 3 },
                    { 18, "206", 5 },
                    { 10, "hydrogenation", 3 },
                    { 8, "continuity between the ancient and modern games", 2 },
                    { 7, "sports as a means for securing harmony among nations", 2 },
                    { 6, "speed, perfection and strength", 2 },
                    { 5, "unity among various nations of the world", 2 },
                    { 4, "Amsterdam Games (1928)", 1 },
                    { 3, "Paris Games (1924)", 1 },
                    { 2, "London Games (1908)", 1 },
                    { 9, "saponification", 3 },
                    { 19, "212", 5 },
                    { 20, "218", 5 },
                    { 21, "studying population dynamics", 6 },
                    { 38, "Physiology or Medicine", 10 },
                    { 37, "Physics and Chemistry", 10 },
                    { 36, "Australia", 9 },
                    { 35, "Europe", 9 },
                    { 34, "Africa", 9 },
                    { 33, "Asia", 9 },
                    { 32, "The formation of rocks", 8 },
                    { 31, "The origin and history of technical and scientific terms", 8 },
                    { 30, "Insects", 8 },
                    { 29, "Behavior of human beings", 8 },
                    { 28, "None of the above", 7 },
                    { 27, "longest railway station", 7 },
                    { 26, "highest railway station", 7 },
                    { 25, "largest railway station", 7 },
                    { 24, "All of the above", 6 },
                    { 23, "evolving population policies, family planning and related programmes", 6 },
                    { 22, "collecting population data", 6 },
                    { 79, "potential energy to kinetic energy", 20 },
                    { 80, "dynamic to static", 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Options_QuestionId",
                table: "Options",
                column: "QuestionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Quizzes");

            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
