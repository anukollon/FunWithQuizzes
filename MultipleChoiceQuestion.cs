using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    public class MultipleChoiceQuestion:Question
    {
        public String CorrectAnswer { get; }
        public static string typeOfQuestion = "MULTIPLE_CHOICE";
        public MultipleChoiceQuestion(string strQuestion, List<string> options, string correctAnswer) : base(strQuestion, options, typeOfQuestion)
        {
            CorrectAnswer = correctAnswer;
        }
    }
}
