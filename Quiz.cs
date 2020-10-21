using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    public class Quiz
    {
        public int DisplayChoices()
        {
            Console.WriteLine("Select an item from the list:");
            List<string> listChoices = new List<string>();
            listChoices.Add("1 - Add Questions");
            listChoices.Add("2 - Run the Quiz");
            listChoices.Add("3 - Exit");
            return PrintChoices(listChoices);            
        }

        public int PrintChoices(List<string> listChoices)
        {
            bool isValidChoice = false;
            int choiceIdx;
            do
            {

                foreach( string item in listChoices){
                    Console.WriteLine(item);
                }
                string input = Console.ReadLine();

                choiceIdx = int.Parse(input);

                if (choiceIdx < 1 || choiceIdx > listChoices.Count)
                {
                    Console.WriteLine("Invalid choices. Try again.");
                }
                else
                {
                    isValidChoice = true;
                }

            } while (!isValidChoice);

            return choiceIdx;

        }

        public Question AddQuiz()
        {
            Console.WriteLine("Select the type of Question");
            List<string> listChoices = new List<string>();
            listChoices.Add("1 - Multiple Choices");
            listChoices.Add("2 - Checkbox");
            listChoices.Add("3 - True or False");
            int choice = PrintChoices(listChoices);

            if(choice == 1) // Multiple Choices
            {
                Console.WriteLine("Please enter the Question Body:");
                string questionBody = Console.ReadLine();
                List<string> options = new List<string>();

                Console.WriteLine("Please enter Option A:");
                options.Add(Console.ReadLine());

                Console.WriteLine("Please enter Option B:");
                options.Add(Console.ReadLine());

                Console.WriteLine("Please enter Option C:");
                options.Add(Console.ReadLine());

                Console.WriteLine("Please enter Option D:");
                options.Add(Console.ReadLine());

                Console.WriteLine("Please enter the correct answer");
                string answer = Console.ReadLine();

                MultipleChoiceQuestion multipleChoice = new MultipleChoiceQuestion(questionBody, options, answer);
                return multipleChoice;
            }
            else if(choice == 2) //Checkbox 
            {
                 
            }

            return null;

        }
    }
}
