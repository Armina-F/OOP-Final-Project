using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Final_Project
{
    public class ExamClass
    {
        public int ExamId { get; set; }
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public int CorrectAnswerId { get; set; }
        public int StudentAnswerId { get; set; }
    }
}
