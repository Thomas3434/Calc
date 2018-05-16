using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Game
    {
        int challengesProvided = 0;
        int correctAnswers = 0;

        internal void ProvideChallenge()
        {
            while (challengesProvided < 10)
            {
                GenerateChallenge challenge = new GenerateChallenge();
                Sum Challenge = challenge.GetSum();

                Console.Write($"{Challenge.challenge}");

                int inputAnswer;
                if (int.TryParse(Console.ReadLine(), out inputAnswer))
                {
                    Compare(inputAnswer, Challenge.solution);
                }
                else
                {
                    Console.WriteLine("That is not a valid input.");
                    return;
                }
            }

            GameSummary();    
        }

        internal void Compare(int answer, int solution)
        {
            int left = Console.CursorLeft;
            int top = Console.CursorTop;
            Console.SetCursorPosition(left + 13, top - 1);

            if (answer == solution)
            {
                Console.Write("Correct!");
                Console.WriteLine();
                Console.WriteLine();
                challengesProvided++;
                correctAnswers++;
                ProvideChallenge();
            }

            else
            {
                Console.Write($"False! The correct answer is {solution}.");
                Console.WriteLine();
                Console.WriteLine();
                challengesProvided++;
                ProvideChallenge();
            }
        }

        internal void GameSummary()
        {
            string verdict;
            if (correctAnswers < 6)
                verdict = "Better luck next time!";
            else if (correctAnswers < 8)
                verdict = "Not bad!";
            else if (correctAnswers < 10)
                verdict = "Well done!";
            else
                verdict = "PERFECT SCORE!";

            Console.WriteLine($"Challenge completed! You got {correctAnswers} out of 10 challenges correct, {verdict}");
            Console.WriteLine("Hit the Enter key to go to the main menu.");
            Console.ReadLine();
            var p = new Program();
            p.MainMenu();
        }

    
        
    }
}
