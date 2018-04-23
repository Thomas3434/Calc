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

            Console.WriteLine($"Challenge is: {Challenge.challenge}");
            Console.WriteLine($"Outcome is: {Challenge.outcome}");
            Console.ReadLine();
            StartGame();

        }
    
    }

}
