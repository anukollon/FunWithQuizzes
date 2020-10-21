using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    public class Question
    {
        public string StrQuestion { get; }
        public List<string> Options { get; }

        public string TypeOfQuestion { get; }

        public Question(string strQuestion, List<string> options, string typeOfQuestion)
        {
            StrQuestion = strQuestion;
            Options = options;
            TypeOfQuestion = typeOfQuestion;
        }

    }
}
