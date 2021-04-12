using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz_WebApp.Models
{
    public class QuizViewModel
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public int CorrectAnswer { get; set; }
        public List<Option> Options { get; set; }
        public int SelectedOptionId { get; set; }
    }
}
