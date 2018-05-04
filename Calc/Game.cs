using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Game
    {
        internal void StartGame()
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
                NextChallenge();
            }

            else
            {
                Console.Write($"False! The correct answer is {solution}.");
                Console.WriteLine();
                Console.WriteLine();
                NextChallenge();
            }
        }

        internal void NextChallenge()
        {
            //TO-DO: provide 10 challenges, then go back to main menu
            Console.WriteLine("Hit the Enter key to go to the main menu.");
            Console.ReadLine();
            var p = new Program();
            p.MainMenu();
        }
        
    }
}
