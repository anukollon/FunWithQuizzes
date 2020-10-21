using System;
using System.Collections.Generic;

namespace FunWithQuizzes
{
    class Program
    {
        public static List<Question> listOfQuestions = new List<Question>();
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with Quizzes");
            
            bool alwaysShow = true;
            Quiz quiz = new Quiz();
            do
            {
                int choiceIndex = quiz.DisplayChoices();
                if(choiceIndex == 1)
                {
                    //Add Questions
                    listOfQuestions.Add(quiz.AddQuiz());
                } else if(choiceIndex == 2)
                {
                    Console.WriteLine("\n******************  QUIZ TIME  **********************\n");
                    //Run the Quiz
                    LoadQuestions();
                    int counter = 1;
                    foreach(Question question in listOfQuestions)
                    {
                        if(question.TypeOfQuestion == "MULTIPLE_CHOICE")
                        {
                            Console.WriteLine("\n"+counter + ": MULTIPLE CHOICE QUESTION:\n");
                            Console.WriteLine(question.StrQuestion);
                            int index = 1;
                            foreach(string opt in question.Options)
                            {
                                Console.WriteLine(index+": "+opt);
                                index++;
                            }
                            Console.WriteLine("Your Answer: ");
                            Console.ReadLine(); 
                        }
                        counter++;
                    }
                    
                } else
                {
                    break;
                }

            } while (alwaysShow);
        }

        public static void LoadQuestions()
        {
            MultipleChoiceQuestion multipleChoice1 = new MultipleChoiceQuestion("Boeing Logo is inspired from which company logo?", new List<string>{ "AirBus", "McDonnell Douglas", "Embraer", "Textron" }, "McDonnell Douglas");
            listOfQuestions.Add(multipleChoice1);

            MultipleChoiceQuestion multipleChoice2 = new MultipleChoiceQuestion("Which is the smallest planet in the Solar System?", new List<string> { "Earth", "Mercury", "Jupiter", "Mars" }, "Mercury");
            listOfQuestions.Add(multipleChoice2);

            CheckboxQuestion checkBox1 = new CheckboxQuestion("Select the Computer Programming Languages.", new List<string> { "Python", "Alpha", "Rust", "Ruby" }, new List<int> {1,3,4});
            listOfQuestions.Add(checkBox1);

            TrueOrFalseQuestion trueOfFalse = new TrueOrFalseQuestion("Rust is a Programming Language", "True");
            listOfQuestions.Add(trueOfFalse);
        }
    }
}
