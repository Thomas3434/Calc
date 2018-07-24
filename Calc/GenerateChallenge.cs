using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class GenerateChallenge
    {
        Random random = new Random();

        internal Sum GetSum()
        {
            Sum sum = new Sum();
            sum.number1 = GetRandomNumber();
            sum.number2 = GetRandomNumber();

            Random random = new Random();
            int randomOperator = random.Next(0, 4);

            switch (randomOperator)
            {
                case (0):
                    sum.solution = sum.number1 * sum.number2;
                    sum.challenge = sum.number1 + " * " + sum.number2 + " = ";
                    break;

                case (1):
                    sum = DivideCalc(sum);
                    break;

                case (2):
                    sum.solution = sum.number1 + sum.number2;
                    sum.challenge = sum.number1 + " + " + sum.number2 + " = ";
                    break;

                case (3):
                    sum.solution = sum.number1 - sum.number2;
                    sum.challenge = sum.number1 + " - " + sum.number2 + " = ";
                    break;

                default:
                    break;
            }
            
                return sum;
           
        }

        private int GetRandomNumber()
        {
            if (Settings.gameDifficulty == "easy")
            {
                int number = random.Next(1, 11);
                return number;
            }
            else
            {
                int number = random.Next(1, 101);
                return number;
            }        
        }

        private Sum DivideCalc(Sum sum)
        {
            int mod = sum.number1 % sum.number2;
            sum.number1 = sum.number1 - mod;

            sum.solution = sum.number1 / sum.number2;
            sum.challenge = sum.number1 + " / " + sum.number2 + " = ";

           /* double outcome = (double)sum.number1 / (double)sum.number2;

            while ((outcome != Math.Floor(outcome)) || (sum.number1 == sum.number2))
            {
                sum.number1 = GetRandomNumber();
                sum.number2 = GetRandomNumber();
                outcome = (double)sum.number1 / (double)sum.number2;
            }

            sum.solution = (int)outcome;

            sum.challenge = sum.number1 + " / " + sum.number2 + " = ";
            */
            return sum;
        }
    }
}

