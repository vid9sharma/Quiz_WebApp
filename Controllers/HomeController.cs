using Microsoft.AspNetCore.Mvc;
using Quiz_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz_WebApp.Controllers
{
    public class HomeController : Controller
    {
        private QuizContext context { get; set; }
        public HomeController(QuizContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var session = new QuizSession(HttpContext.Session);
            var questions = context.Questions.OrderBy(q => Guid.NewGuid()).Take(10).ToList();
            session.SetMyQuestions(questions);

            return View();
        }

        [HttpGet]
        public IActionResult Details()
        {
            var quizzes = context.Quizzes.ToList();

            return View(quizzes);
        }
    }
}
