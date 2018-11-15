using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class OpenQuestion : IQuestion
    {
        private string text, answer;

        public OpenQuestion(string questionText, string questionAnswer)
        {
            text = questionText;
            answer = questionAnswer;
        }

        public bool checkAnswer(string response)
        {
            return response.Contains(answer);
        }

        public void Display()
        {
            Console.WriteLine(text);
        }
        
    }
}
