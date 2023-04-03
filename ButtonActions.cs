using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculatorWinForms
{
    public class ButtonActions
    {
        public static string DeleteText(string numberString)
        {
            int lengthNumber = numberString.Length;
            if (lengthNumber == 0)
            {
                return "0";
            }
            else
            {
                string newNumber = string.Empty;
                for (int i = 0; i < (lengthNumber - 1); i++)
                {
                    newNumber += numberString[i];
                }
                return newNumber;
            }

        }

    }
}
