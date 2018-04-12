using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class GenerateChallenge
    {
      
        private Sum GetSum()
        {
            Sum sum = new Sum();
            sum.number1 = GetRandomNumber();
            sum.number2 = GetRandomNumber();

            Random random = new Random();
            int randomOperator = random.Next(0, 3);

            switch (randomOperator)
            {
                case (0):
                    sum.outcome = sum.number1 * sum.number2;
                    sum.sum = sum.number1 + " * " + sum.number2 + " = ";
                    break;

                case (1):
                    sum = DivideCalc(sum);
                    break;

                case (2):
                    sum.outcome = sum.number1 + sum.number2;
                    sum.sum = sum.number1 + " + " + sum.number2 + " = ";
                    break;

                case (3):
                    sum.outcome = sum.number1 - sum.number2;
                    sum.sum = sum.number1 + " - " + sum.number2 + " = ";
                    break;

                default:
                    break;
            }
            return sum;
        }

        private int GetRandomNumber()
        {
            Random random = new Random();
            int number = random.Next(1, 11); //should become changeable with difficulty setting
            return number;
        }

        private Sum DivideCalc(Sum sum)
        {
            double outcome = sum.number1 / sum.number2;

            while (outcome != Math.Floor(outcome))
            {
                sum.number1 = GetRandomNumber();
                sum.number2 = GetRandomNumber();
                outcome = sum.number1 / sum.number2;
            }

            sum.outcome = (int)outcome;

            sum.sum = sum.number1 + " / " + sum.number2 + " = ";

            return sum;
        }
    }
}

