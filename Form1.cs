using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculatorWinForms
{
    public partial class FormCalculator : System.Windows.Forms.Form
    {
        private void ClearMemory()
        {
            MemoryNumber1 = 0;
            MemoryNumber2 = 0;
            MemoryResult = 0;
            MemoryOperator = string.Empty;
        }

        private void DeleteText(string textFromDisplay)
        {
            int lengthNumber = textFromDisplay.Length;
            if (lengthNumber == 0)
            {
                textBoxDisplay.Text = "0";
            }
            else
            {
                string newNumber = string.Empty;
                for (int i = 0; i < (lengthNumber - 1); i++)
                {
                    newNumber += textFromDisplay[i];
                }
                textBoxDisplay.Text = newNumber;
            }

        }

        private void NumberInput(string textFromDisplay, string buttonNumber)
        {
            if (textFromDisplay == "0")
            {
                textBoxDisplay.Text = buttonNumber;
            }
            else
            {
                textBoxDisplay.Text += buttonNumber;
            }
        }

        public FormCalculator()
        {
            InitializeComponent();
        }

        private double MemoryNumber1 = 0;
        private double MemoryNumber2 = 0;
        private double MemoryResult = 0;

        public string MemoryOperator = string.Empty;

        //
        // Clear all variable and text boxes, set 0
        //
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "0";
            textBoxHistory.Text = string.Empty;
            ClearMemory();
        }
        //
        // Clear only the number in Display
        //
        private void buttonClearNumber_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "0";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteText(textBoxHistory.Text);
        }

        //
        // Numbers
        //
        private void buttonNumber0_Click(object sender, EventArgs e)
        {
            NumberInput(textBoxDisplay.Text, "0");
        }

        private void buttonNumber1_Click(object sender, EventArgs e)
        {
            NumberInput(textBoxDisplay.Text, "1");
        }

        private void buttonNumber2_Click(object sender, EventArgs e)
        {
            NumberInput(textBoxDisplay.Text, "2");
        }

        private void buttonNumber3_Click(object sender, EventArgs e)
        {
            NumberInput(textBoxDisplay.Text, "3");
        }

        private void buttonNumber4_Click(object sender, EventArgs e)
        {
            NumberInput(textBoxDisplay.Text, "4");
        }

        private void buttonNumber5_Click(object sender, EventArgs e)
        {
            NumberInput(textBoxDisplay.Text, "5");
        }

        private void buttonNumber6_Click(object sender, EventArgs e)
        {
            NumberInput(textBoxDisplay.Text, "6");
        }

        private void buttonNumber7_Click(object sender, EventArgs e)
        {
            NumberInput(textBoxDisplay.Text, "7");
        }

        private void buttonNumber8_Click(object sender, EventArgs e)
        {
            NumberInput(textBoxDisplay.Text, "8");
        }

        private void buttonNumber9_Click(object sender, EventArgs e)
        {
            NumberInput(textBoxDisplay.Text, "9");
        }
    }
}
