using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class ChoiceQuestion : Question
    {
        private List<String> choices;
        private string text;
        
        public ChoiceQuestion()
        {
            choices = new List<string>();
        }

        public void AddChoice(string choice, bool answer)
        {
            choices.Add(choice);
            if (answer)
            {
                string choiceString = "" + choices.Count();
                SetAnswer(choiceString);
            }
        }

        

        public override void Display()
        {
            base.Display();
            for (int i = 0; i < choices.Count(); i++)
            {
                int choiceNumber = i + 1;
                Console.WriteLine("{0} : {1}", choiceNumber, choices.ElementAt(i));
            }
        }
    }
}
