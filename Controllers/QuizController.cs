using Microsoft.AspNetCore.Mvc;
using Quiz_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz_WebApp.Controllers
{
    public class QuizController : Controller
    {
        private QuizContext context { get; set; }
        public QuizController(QuizContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var session = new QuizSession(HttpContext.Session);

            //get first question
            var question = session.GetMyQuestions().FirstOrDefault();

            ViewBag.Previous = false;
            ViewBag.Action = "Next";
            ViewBag.QuesNo = 1;

            List<QuizViewModel> quesVMList = new List<QuizViewModel>();

            //get QuestionViewModel for the question
            var quesVM = GetQuestionViewModel(question);

            //adding first question to list in session
            quesVMList.Add(quesVM);
            session.SetMyQuestionViewModel(quesVMList);

            return View(quesVM);
        }

        [HttpPost]
        public IActionResult Result(QuizViewModel quesViewModel)
        {
            var session = new QuizSession(HttpContext.Session);

            List<Question> listOfQuestions = session.GetMyQuestions();

            //get index of the question displayed on the screen
            int index = listOfQuestions.FindIndex(q => q.QuestionId == quesViewModel.QuestionId);

            //saving selected option in the QuestionViewModel
            var questionViewModelList = session.GetMyQuestionViewModel();
            questionViewModelList[index].SelectedOptionId = quesViewModel.SelectedOptionId;
            session.SetMyQuestionViewModel(questionViewModelList);

            // clear model state
            ModelState.Clear();

            var score = 0;
            //if present displayed question is not last question then condition is true
            if (index < (listOfQuestions.Count - 1))
            {
                //select next question
                var question = listOfQuestions[index + 1];
                ViewBag.Previous = true;
                ViewBag.Action = "Next";

                //if next question to be displayed is last
                if ((index + 1) >= (listOfQuestions.Count - 1))
                {
                    ViewBag.Action = "Submit";
                }

                ViewBag.QuesNo = index + 2;

                var quesVM = GetQuestionViewModel(question);

                //adding question to list in QuestionViewModel list of session if not already added
                if (!questionViewModelList.Select(q => q.QuestionId).Contains(quesVM.QuestionId))
                {
                    questionViewModelList.Add(quesVM);
                    session.SetMyQuestionViewModel(questionViewModelList);
                }
                else
                {
                    quesVM = session.GetMyQuestionViewModel()[index + 1];
                }
                return View("Index", quesVM);
            }
            else
            {
                //submit is pressed on last question so calculate score
                questionViewModelList = session.GetMyQuestionViewModel();
                foreach (var question in questionViewModelList)
                {
                    if (question.CorrectAnswer == question.SelectedOptionId)
                    {
                        score++;
                    }
                }

                Quiz quiz = new Quiz();
                quiz.Score = score;
                quiz.QuizDate = DateTime.Now;

                context.Quizzes.Add(quiz);
                context.SaveChanges();
                return View(quiz);
            }
        }

        public IActionResult Previous(int id)
        {
            var session = new QuizSession(HttpContext.Session);

            //get list of questions from QuestionViewModel in session
            var listOfQuestions = session.GetMyQuestionViewModel();

            //get index of question displayed on the screen
            int index = listOfQuestions.FindIndex(q => q.QuestionId == id);

            //get previous question
            var quesVM = listOfQuestions[index - 1];

            if (index <= 1)
            {
                ViewBag.Previous = false;
            }
            else
            {
                ViewBag.Previous = true;
            }

            ViewBag.Action = "Next";
            ViewBag.QuesNo = index;

            return View("Index", quesVM);
        }

        //generic method to create QuestionViewModel with Question and its Options
        public QuizViewModel GetQuestionViewModel(Question question)
        {
            var options = context.Options.Where(o => o.QuestionId == question.QuestionId).ToList();
            var quesVM = new QuizViewModel()
            {
                QuestionId = question.QuestionId,
                QuestionText = question.QuestionText,
                Options = options,
                CorrectAnswer = question.CorrectAnswer
            };
            return quesVM;
        }
    }
}
