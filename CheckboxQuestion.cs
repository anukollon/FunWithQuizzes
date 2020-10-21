using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    public class CheckboxQuestion:Question
    {
        public List<int> AnswerList;
        public static string typeOfQuestion = "CHECKBOX";
        public CheckboxQuestion(string strQuestion, List<string> options,  List<int> answerList): base(strQuestion, options, typeOfQuestion)
        {
            AnswerList = answerList;
        }
    }
}
