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
        private void MemoryFillEquals ()
        {
            textBoxHistory.Text = textBoxHistory.Text + textBoxDisplay.Text + " = ";
            double.TryParse(textBoxDisplay.Text, out MemoryNumber2);
            if ((MemoryNumber2 == 0) && (MemoryOperator == "/"))
            {
                textBoxDisplay.Text = "Cannot divide by zero";
            }
            else
            {
                MemoryResult = Calculations.CalculateSwitch(MemoryNumber1, MemoryNumber2, MemoryOperator);
                textBoxHistory.Text += MemoryResult;
                textBoxDisplay.Text = string.Empty + MemoryResult;
            }

            ClearMemory();
        }

        private void MemoryFill(string TextFromDisplay, string UserOperator)
        {
            // MemoryFill(textBoxDisplay.Text,"+");
            if (MemoryNumber1 == 0)
            {
                MemoryOperator = UserOperator;
                textBoxHistory.Text = textBoxDisplay.Text + " " + MemoryOperator + " ";
                double.TryParse(textBoxDisplay.Text, out MemoryNumber1);
                textBoxDisplay.Text = string.Empty;

            }
            else if (MemoryNumber1 != 0) //vypocet
            {
                MemoryFillEquals();
                MemoryOperator = UserOperator;
                double.TryParse(textBoxDisplay.Text, out MemoryNumber1);
                textBoxHistory.Text = MemoryNumber1 + " " + MemoryOperator;
                textBoxDisplay.Text = string.Empty;
                
            }
        }

        public FormCalculator()
        {
            InitializeComponent();
        }

        private double MemoryNumber1 = 0;
        private double MemoryNumber2 = 0;
        private double MemoryResult = 0;

        private string DeleteNumber = string.Empty;
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
        //
        // Delete 1 number from the endn
        //
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteNumber = ButtonActions.DeleteText(textBoxDisplay.Text);
            textBoxDisplay.Text = DeleteNumber;
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
        //
        // Reverse number, static method
        //
        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            bool isNumber = double.TryParse(textBoxDisplay.Text, out double number);

            textBoxDisplay.Text = Calculations.Revese(number);
        }
        //
        // Decimal point, only 1 possible
        //
        private void buttonDecimalPoint_Click(object sender, EventArgs e)
        {
            if (!textBoxDisplay.Text.Contains("."))
            {
                textBoxDisplay.Text += ".";
            }

        }
        //
        // Choosing Operation, filling memoris in method MemoryFill
        //
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            MemoryFill(textBoxDisplay.Text,"+");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            MemoryFill(textBoxDisplay.Text, "-");
        }

        private void buttonMultiple_Click(object sender, EventArgs e)
        {
            MemoryFill(textBoxDisplay.Text, "*");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            MemoryFill(textBoxDisplay.Text, "/");
        }

        //
        // Equals = start calculations
        //
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            MemoryFillEquals();
        }
        //
        // Keyboard down
        //
        private void FormCalculator_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.D0) || (e.KeyCode == Keys.NumPad0))
            {
                buttonNumber0_Click(sender, e);
            }
            else if ((e.KeyCode == Keys.D1) || (e.KeyCode == Keys.NumPad1))
            {
                buttonNumber1_Click(sender, e);
            }
            else if ((e.KeyCode == Keys.D2) || (e.KeyCode == Keys.NumPad2))
            {
                buttonNumber2_Click(sender, e);
            }
            else if ((e.KeyCode == Keys.D3) || (e.KeyCode == Keys.NumPad3))
            {
                buttonNumber3_Click(sender, e);
            }
            else if ((e.KeyCode == Keys.D4) || (e.KeyCode == Keys.NumPad4))
            {
                buttonNumber4_Click(sender, e);
            }
            else if ((e.KeyCode == Keys.D5) || (e.KeyCode == Keys.NumPad5))
            {
                buttonNumber5_Click(sender, e);
            }
            else if ((e.KeyCode == Keys.D6) || (e.KeyCode == Keys.NumPad6))
            {
                buttonNumber6_Click(sender, e);
            }
            else if ((e.KeyCode == Keys.D7) || (e.KeyCode == Keys.NumPad7))
            {
                buttonNumber7_Click(sender, e);
            }
            else if ((e.KeyCode == Keys.D8) || (e.KeyCode == Keys.NumPad8))
            {
                buttonNumber8_Click(sender, e);
            }
            else if ((e.KeyCode == Keys.D9) || (e.KeyCode == Keys.NumPad9))
            {
                buttonNumber9_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                buttonClearNumber_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Back)
            {
                buttonDelete_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Oemplus)
            {
                buttonEquals_Click(sender, e);
            }
            else if (e.KeyCode == Keys.OemMinus)
            {
                buttonMinus_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Oem2)
            {
                buttonDivide_Click(sender, e);
            }
            else if (e.KeyCode == Keys.OemPeriod)
            {
                buttonDecimalPoint_Click(sender, e);
            }
            else if ((e.KeyCode == Keys.ShiftKey) || (e.KeyCode == Keys.D8))
            {
                buttonMultiple_Click(sender, e);
            }
            else if ((e.KeyCode == Keys.ShiftKey) || (e.KeyCode == Keys.Oemplus))
            {
                buttonPlus_Click(sender, e);
            }
        }
    }
}
