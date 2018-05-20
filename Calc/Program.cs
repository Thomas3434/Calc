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
            var p = new Program();
            p.MainMenu();
        }

        internal void MainMenu()
        {
            Console.Clear(); 
            Console.WriteLine("Lets do some Calc!");
            GameSettings();
        }

        public void GameSettings()
        {
            Console.WriteLine("Choose difficulty:");
            Console.WriteLine("1) Easy");
            Console.WriteLine("2) Hard");
            Console.Write("My choice: ");
            string myChoice = Console.ReadLine();

            switch (myChoice.ToLowerInvariant())
            {
                case "1":
                    Settings.gameDifficulty = "easy";
                    break;

                case "2":
                    Settings.gameDifficulty = "hard";
                    break;

                default:
                    Console.WriteLine("Choose either 1 or 2.");
                    GameSettings();
                    break;
            }
            Startgame();
        }

        static void Startgame()
        {
            Console.Clear();
            Console.WriteLine("Here we go!");
            Console.WriteLine();
            Game start = new Game();
            start.ProvideChallenge();
        }
    }
}
