﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Question first = new Question();
            first.SetText("Who was the inventor of Java?");
            first.SetAnswer("James Gosling");
            first.SetCategory("IT");
            first.SetDifficulty(2);
            ChoiceQuestion second = new ChoiceQuestion();
            second.SetText("In which country was the inventor of Java born?");
            second.AddChoice("Australia", false);
            second.AddChoice("Canada", true);
            second.AddChoice("Denmark", false);
            second.AddChoice("United States", false);
            second.SetCategory("IT");
            second.SetDifficulty(1);

            Console.WriteLine("Welke categorie wilt u?");
            first.CategorySorter();

            PresentQuestion(first);
            PresentQuestion(second);
        }

        
        public static void PresentQuestion(Question q)
        {
            q.Display();
            Console.WriteLine("Your answer: ");
            string response = Console.ReadLine();
            Console.WriteLine(q.CheckAnswer(response));
            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }







    }
}
