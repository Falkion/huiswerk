using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class ChoiceQuestion : IQuestion
    {
        private List<String> choices;
        private string text;
        
        public ChoiceQuestion(string questionText)
        {
            text = questionText;
            choices = new List<string>();
        }

        public void addChoice(string choice, bool answer)
        {
            choices.Add(choice);
        }

        public void Display()
        {
            Console.WriteLine(text);
            for (int i = 0; i < choices.Count(); i++)
            {
                int choiceNumber = i + 1;
                Console.WriteLine("{0} : {1}", choiceNumber, choices.ElementAt(i));
            }
        }
    }
}
