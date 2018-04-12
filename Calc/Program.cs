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
            Sum Challenge = new Sum();

            Console.WriteLine("Challenge is:", Challenge.sum);
            Console.WriteLine("Outcome is:", Challenge.sum);
            Console.ReadLine();

        }
    
    }

}
