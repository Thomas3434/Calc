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
            //  Console.Clear(); 
            // Comment the above part in again once the Game.NextChallenge method TO-DO's are completed 
            Console.WriteLine("Lets do some Calc!");
            Settings();
        }

        static void Settings()
        {
            Console.WriteLine("[This is a placeholder difficulty menu]");
            Console.WriteLine("Press Enter key...");
            Console.ReadLine();
            //TO-DO: functionality to choose difficulty
            Game start = new Game();
            start.StartGame();
        }

       
    }
}
