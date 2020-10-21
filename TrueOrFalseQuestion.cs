using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    public class TrueOrFalseQuestion : Question
    {
        public string Answer { get; }
        public static string typeOfQuestion = "TRUE_OR_FALSE";
        public static List<string> options = new List<string> { "True", "False" };
        public TrueOrFalseQuestion(string strQuestion,   string answer) : base(strQuestion, options, typeOfQuestion)
        {
            Answer = answer;
        }
    }
}
