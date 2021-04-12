using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz_WebApp.Models
{
    public class QuizSession
    {
        private const string QuestionsKey = "myQuestions";
        private const string CountKey = "questionCount";
        private const string QuesViewModel = "quesViewModel";
        private ISession session { get; set; }
        public QuizSession(ISession session)
        {
            this.session = session;
        }

        public void SetMyQuestions(List<Question> questions)
        {
            session.SetObject(QuestionsKey, questions);
            session.SetInt32(CountKey, questions.Count);
        }

        public List<Question> GetMyQuestions()
        {
            return session.GetObject<List<Question>>(QuestionsKey) ?? new List<Question>();
        }

        public void SetMyQuestionViewModel(List<QuizViewModel> quesVM)
        {
            session.SetObject(QuesViewModel, quesVM);
        }

        public List<QuizViewModel> GetMyQuestionViewModel()
        {
            return session.GetObject<List<QuizViewModel>>(QuesViewModel) ?? new List<QuizViewModel>();
        }
    }
}
