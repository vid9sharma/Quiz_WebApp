using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz_WebApp.Models
{
    public class QuizContext : DbContext
    {
        public QuizContext(DbContextOptions<QuizContext> options) : base(options)
        {

        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    QuestionId = 1,
                    QuestionText = "The Olympic Flame, was, for the first time, ceremonially lighted and burnt in a giant torch at the entrance of the stadium at",
                    CorrectAnswer = 4
                },
                new Question
                {
                    QuestionId = 2,
                    QuestionText = "The Olympic Flame symbolises",
                    CorrectAnswer = 8
                },
                new Question
                {
                    QuestionId = 3,
                    QuestionText = "The reaction which converts sugar solution into alcohol is an example of",
                    CorrectAnswer = 11
                },
                new Question
                {
                    QuestionId = 4,
                    QuestionText = "The Scottish bacteriologist who discovered penicillin was",
                    CorrectAnswer = 13
                },
                new Question
                {
                    QuestionId = 5,
                    QuestionText = "The number of already named bones in the human skeleton is",
                    CorrectAnswer = 18
                },
                new Question
                {
                    QuestionId = 6,
                    QuestionText = "The purpose of United Nations Fund for Population Activities (UNFPA) is",
                    CorrectAnswer = 24
                },
                new Question
                {
                    QuestionId = 7,
                    QuestionText = "Grand Central Terminal, Park Avenue, New York is the world's",
                    CorrectAnswer = 25
                },
                new Question
                {
                    QuestionId = 8,
                    QuestionText = "Entomology is the science that studies",
                    CorrectAnswer = 30
                },
                new Question
                {
                    QuestionId = 9,
                    QuestionText = "Eritrea, which became the 182nd member of the UN in 1993, is in the continent of",
                    CorrectAnswer = 34
                },
                new Question
                {
                    QuestionId = 10,
                    QuestionText = "For which of the following disciplines is Nobel Prize awarded?",
                    CorrectAnswer = 40
                },
                new Question
                {
                    QuestionId = 11,
                    QuestionText = "Hitler party which came into power in 1933 is known as",
                    CorrectAnswer = 42
                },
                new Question
                {
                    QuestionId = 12,
                    QuestionText = "In which year of First World War Germany declared war on Russia and France?",
                    CorrectAnswer = 45
                },
                new Question
                {
                    QuestionId = 13,
                    QuestionText = "ICAO stands for",
                    CorrectAnswer = 49
                },
                new Question
                {
                    QuestionId = 14,
                    QuestionText = "India has largest deposits of ____ in the world.",
                    CorrectAnswer = 55
                },
                new Question
                {
                    QuestionId = 15,
                    QuestionText = "Epsom (England) is the place associated with",
                    CorrectAnswer = 57
                },
                new Question
                {
                    QuestionId = 16,
                    QuestionText = "First human heart transplant operation conducted by Dr. Christiaan Barnard on Louis Washkansky, was conducted in",
                    CorrectAnswer = 61
                },
                new Question
                {
                    QuestionId = 17,
                    QuestionText = "Galileo was an Italian astronomer who",
                    CorrectAnswer = 68
                },
                new Question
                {
                    QuestionId = 18,
                    QuestionText = "Exposure to sunlight helps a person improve his health because",
                    CorrectAnswer = 72
                },
                new Question
                {
                    QuestionId = 19,
                    QuestionText = "Guarantee to an exporter that the importer of his goods will pay immediately for the goods ordered by him, is known as",
                    CorrectAnswer = 73
                },
                new Question
                {
                    QuestionId = 20,
                    QuestionText = "Friction can be reduced by changing from",
                    CorrectAnswer = 77
                });

            modelBuilder.Entity<Option>().HasData(
                new Option
                {
                    OptionId = 1,
                    OptionText = "Athens Games (1896)",
                    QuestionId = 1
                },
                new Option
                {
                    OptionId = 2,
                    OptionText = "London Games (1908)",
                    QuestionId = 1
                },
                new Option
                {
                    OptionId = 3,
                    OptionText = "Paris Games (1924)",
                    QuestionId = 1
                },
                new Option
                {
                    OptionId = 4,
                    OptionText = "Amsterdam Games (1928)",
                    QuestionId = 1
                },
                new Option
                {
                    OptionId = 5,
                    OptionText = "unity among various nations of the world",
                    QuestionId = 2
                },
                new Option
                {
                    OptionId = 6,
                    OptionText = "speed, perfection and strength",
                    QuestionId = 2
                },
                new Option
                {
                    OptionId = 7,
                    OptionText = "sports as a means for securing harmony among nations",
                    QuestionId = 2
                },
                new Option
                {
                    OptionId = 8,
                    OptionText = "continuity between the ancient and modern games",
                    QuestionId = 2
                },
                new Option
                {
                    OptionId = 9,
                    OptionText = "saponification",
                    QuestionId = 3
                },
                new Option
                {
                    OptionId = 10,
                    OptionText = "hydrogenation",
                    QuestionId = 3
                },
                new Option
                {
                    OptionId = 11,
                    OptionText = "fermentation",
                    QuestionId = 3
                },
                new Option
                {
                    OptionId = 12,
                    OptionText = "hydrolysis",
                    QuestionId = 3
                },
                new Option
                {
                    OptionId = 13,
                    OptionText = "Alexander Fleming",
                    QuestionId = 4
                },
                new Option
                {
                    OptionId = 14,
                    OptionText = "Albert Einstein",
                    QuestionId = 4
                },
                new Option
                {
                    OptionId = 15,
                    OptionText = "Archimeder",
                    QuestionId = 4
                },
                new Option
                {
                    OptionId = 16,
                    OptionText = "Aryabhatta",
                    QuestionId = 4
                },
                new Option
                {
                    OptionId = 17,
                    OptionText = "200",
                    QuestionId = 5
                },
                new Option
                {
                    OptionId = 18,
                    OptionText = "206",
                    QuestionId = 5
                },
                new Option
                {
                    OptionId = 19,
                    OptionText = "212",
                    QuestionId = 5
                },
                new Option
                {
                    OptionId = 20,
                    OptionText = "218",
                    QuestionId = 5
                },
                new Option
                {
                    OptionId = 21,
                    OptionText = "studying population dynamics",
                    QuestionId = 6
                },
                new Option
                {
                    OptionId = 22,
                    OptionText = "collecting population data",
                    QuestionId = 6
                },
                new Option
                {
                    OptionId = 23,
                    OptionText = "evolving population policies, family planning and related programmes",
                    QuestionId = 6
                },
                new Option
                {
                    OptionId = 24,
                    OptionText = "All of the above",
                    QuestionId = 6
                },
                new Option
                {
                    OptionId = 25,
                    OptionText = "largest railway station",
                    QuestionId = 7
                },
                new Option
                {
                    OptionId = 26,
                    OptionText = "highest railway station",
                    QuestionId = 7
                },
                new Option
                {
                    OptionId = 27,
                    OptionText = "longest railway station",
                    QuestionId = 7
                },
                new Option
                {
                    OptionId = 28,
                    OptionText = "None of the above",
                    QuestionId = 7
                },
                new Option
                {
                    OptionId = 29,
                    OptionText = "Behavior of human beings",
                    QuestionId = 8
                },
                new Option
                {
                    OptionId = 30,
                    OptionText = "Insects",
                    QuestionId = 8
                },
                new Option
                {
                    OptionId = 31,
                    OptionText = "The origin and history of technical and scientific terms",
                    QuestionId = 8
                },
                new Option
                {
                    OptionId = 32,
                    OptionText = "The formation of rocks",
                    QuestionId = 8
                },
                new Option
                {
                    OptionId = 33,
                    OptionText = "Asia",
                    QuestionId = 9
                },
                new Option
                {
                    OptionId = 34,
                    OptionText = "Africa",
                    QuestionId = 9
                },
                new Option
                {
                    OptionId = 35,
                    OptionText = "Europe",
                    QuestionId = 9
                },
                new Option
                {
                    OptionId = 36,
                    OptionText = "Australia",
                    QuestionId = 9
                },
                new Option
                {
                    OptionId = 37,
                    OptionText = "Physics and Chemistry",
                    QuestionId = 10
                },
                new Option
                {
                    OptionId = 38,
                    OptionText = "Physiology or Medicine",
                    QuestionId = 10
                },
                new Option
                {
                    OptionId = 39,
                    OptionText = "Literature, Peace and Economics",
                    QuestionId = 10
                },
                new Option
                {
                    OptionId = 40,
                    OptionText = "All of the above",
                    QuestionId = 10
                },
                new Option
                {
                    OptionId = 41,
                    OptionText = "Labour Party",
                    QuestionId = 11
                },
                new Option
                {
                    OptionId = 42,
                    OptionText = "Nazi Party",
                    QuestionId = 11
                },
                new Option
                {
                    OptionId = 43,
                    OptionText = "Ku-Klux-Klan",
                    QuestionId = 11
                },
                new Option
                {
                    OptionId = 44,
                    OptionText = "Democratic Party",
                    QuestionId = 11
                },
                new Option
                {
                    OptionId = 45,
                    OptionText = "1914",
                    QuestionId = 12
                },
                new Option
                {
                    OptionId = 46,
                    OptionText = "1915",
                    QuestionId = 12
                },
                new Option
                {
                    OptionId = 47,
                    OptionText = "1916",
                    QuestionId = 12
                },
                new Option
                {
                    OptionId = 48,
                    OptionText = "1917",
                    QuestionId = 12
                },
                new Option
                {
                    OptionId = 49,
                    OptionText = "International Civil Aviation Organization",
                    QuestionId = 13
                },
                new Option
                {
                    OptionId = 50,
                    OptionText = "Indian Corporation of Agriculture Organization",
                    QuestionId = 13
                },
                new Option
                {
                    OptionId = 51,
                    OptionText = "Institute of Company of Accounts Organization",
                    QuestionId = 13
                },
                new Option
                {
                    OptionId = 52,
                    OptionText = "None of the above",
                    QuestionId = 13
                },
                new Option
                {
                    OptionId = 53,
                    OptionText = "gold",
                    QuestionId = 14
                },
                new Option
                {
                    OptionId = 54,
                    OptionText = "copper",
                    QuestionId = 14
                },
                new Option
                {
                    OptionId = 55,
                    OptionText = "mica",
                    QuestionId = 14
                },
                new Option
                {
                    OptionId = 56,
                    OptionText = "None of the above",
                    QuestionId = 14
                },
                new Option
                {
                    OptionId = 57,
                    OptionText = "Horse racing",
                    QuestionId = 15
                },
                new Option
                {
                    OptionId = 58,
                    OptionText = "Polo",
                    QuestionId = 15
                },
                new Option
                {
                    OptionId = 59,
                    OptionText = "Shooting",
                    QuestionId = 15
                },
                new Option
                {
                    OptionId = 60,
                    OptionText = "Snooker",
                    QuestionId = 15
                },
                new Option
                {
                    OptionId = 61,
                    OptionText = "1967",
                    QuestionId = 16
                },
                new Option
                {
                    OptionId = 62,
                    OptionText = "1968",
                    QuestionId = 16
                },
                new Option
                {
                    OptionId = 63,
                    OptionText = "1958",
                    QuestionId = 16
                },
                new Option
                {
                    OptionId = 64,
                    OptionText = "1922",
                    QuestionId = 16
                },
                new Option
                {
                    OptionId = 65,
                    OptionText = "developed the telescope",
                    QuestionId = 17
                },
                new Option
                {
                    OptionId = 66,
                    OptionText = "discovered four satellites of Jupiter",
                    QuestionId = 17
                },
                new Option
                {
                    OptionId = 67,
                    OptionText = "discovered that the movement of pendulum produces a regular time measurement",
                    QuestionId = 17
                },
                new Option
                {
                    OptionId = 68,
                    OptionText = "All of the above",
                    QuestionId = 17
                },
                new Option
                {
                    OptionId = 69,
                    OptionText = "the infrared light kills bacteria in the body",
                    QuestionId = 18
                },
                new Option
                {
                    OptionId = 70,
                    OptionText = "resistance power increases",
                    QuestionId = 18
                },
                new Option
                {
                    OptionId = 71,
                    OptionText = "the pigment cells in the skin get stimulated and produce a healthy tan",
                    QuestionId = 18
                },
                new Option
                {
                    OptionId = 72,
                    OptionText = "the ultraviolet rays convert skin oil into Vitamin D",
                    QuestionId = 18
                },
                new Option
                {
                    OptionId = 73,
                    OptionText = "Letter of Credit (L/C)",
                    QuestionId = 19
                },
                new Option
                {
                    OptionId = 74,
                    OptionText = "laissezfaire",
                    QuestionId = 19
                },
                new Option
                {
                    OptionId = 75,
                    OptionText = "inflation",
                    QuestionId = 19
                },
                new Option
                {
                    OptionId = 76,
                    OptionText = "None of the above",
                    QuestionId = 19
                },
                new Option
                {
                    OptionId = 77,
                    OptionText = "sliding to rolling",
                    QuestionId = 20
                },
                new Option
                {
                    OptionId = 78,
                    OptionText = "rolling to sliding",
                    QuestionId = 20
                },
                new Option
                {
                    OptionId = 79,
                    OptionText = "potential energy to kinetic energy",
                    QuestionId = 20
                },
                new Option
                {
                    OptionId = 80,
                    OptionText = "dynamic to static",
                    QuestionId = 20
                });
        }
    }
}
