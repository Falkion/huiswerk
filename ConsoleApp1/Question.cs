using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Question
    {
        private string text, answer;

        public Question()
        {
            text = "";
            answer = "";
        }

        public void SetText(string questionText)
        {
            text = questionText;
        }

        public void SetAnswer(string questionAnswer)
        {
            answer = questionAnswer;
        }

        public bool CheckAnswer(string response)
        {
            return response.Contains(answer);
        }

        public virtual void Display()
        {
            Console.WriteLine(text);
        }
        
    }
}
