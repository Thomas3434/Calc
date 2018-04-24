using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //var p = new Program();
            //p.MainMenu();
            MainMenu();
        }

        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Lets do some Calc!");
            //TO-DO: functionality to choose difficulty
            StartGame();
        }

        static void StartGame()
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

        static void Compare(int answer, int solution)
        {
            int left = Console.CursorLeft;
            int top = Console.CursorTop;
            Console.SetCursorPosition(left + 13, top - 1);

            if (answer == solution)
            {
                Console.Write("Correct!");
                Console.WriteLine();
                Console.WriteLine();
                StartGame();
            }

            else
            {
                Console.Write($"False! The correct answer is {solution}.");
                Console.WriteLine();
                Console.WriteLine();
                StartGame();
            }
        }  
    }
}
