using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculatorWinForms
{
    public class Calculations
    {
        public static double CalculateSwitch(double number1, double number2, string chosenOperator)
        {
            switch (chosenOperator)
            {
                case "+": // Sum
                    return Sum(number1, number2);
                case "-": // Subtract
                    return Subtract(number1, number2);
                case "*": // Multiple
                    return Multiple(number1, number2);
                case "/": // Divide
                    return Divide(number1, number2);
                case "00":
                    return 0;
                default:    // neni potreba
                    Console.WriteLine("I can't calculate with your operator.");
                    return 0;
            }
        }

        public static double Sum(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }

        public static double Multiple(double number1, double number2)
        {
            return number1 * number2;
        }

        public static double Divide(double number1, double number2)
        {
            return number1 / number2;
        }

        public static string Reverse(double number1)
        {
            string numberReverseString = string.Empty;
            if (number1 < 0)
            {
                numberReverseString += Math.Abs(number1);
            }
            else if (number1 > 0)
            {
                numberReverseString = "-" + number1;
            }
            else
            { numberReverseString = "0"; }
            return numberReverseString;
        }
    }
}
