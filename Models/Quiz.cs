using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz_WebApp.Models
{
    public class Quiz
    {
        public int QuizId { get; set; }
        public int Score { get; set; }
        public DateTime QuizDate { get; set; }
    }
}
