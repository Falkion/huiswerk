using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Question
    {
        private string text, answer, category;
        private int difficulty;
        private List<string> categories;
        private List<Question> questions;
        public Question()
        {
            text = "";
            answer = "";
            category = "";
            categories = new List<string>();
        }

        public void SetText(string questionText)
        {
            text = questionText;
        }

        public void SetCategory(string questionCategory)
        {
            categories.Add(questionCategory);
        }

        public void SetDifficulty(int questionDifficulty)
        {
            difficulty = questionDifficulty;
        }

        public void SetAnswer(string questionAnswer)
        {
            answer = questionAnswer;
        }

        public void AddQuestion(Question q)
        {
            questions.Add(q);
        }

        public bool CheckAnswer(string response)
        {
            return response.Contains(answer);
        }

        public void CategorySorter()
        {
            var query = from word in categories
                                        orderby word.Substring(0, 1) ascending
                                        select word;
            foreach (string value in query)
            {
                Console.WriteLine(value);
            }
            string answer = Console.ReadLine();
        }


        public virtual void Display()
        {
            Console.WriteLine(text);
        }
        
    }
}
