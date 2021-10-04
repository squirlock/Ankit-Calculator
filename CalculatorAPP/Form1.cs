using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAPP
{
    public partial class Form1 : Form
    {

        Double outputResult = 0;
        String operatorUsed = "";
        String buttonNum = "";
        bool isOperatorUsed = false; // false is NOT USED and true is USED
        bool isButtonEqualTo = false; //false is NOT USED and true is USED
        String aboutDeveloper = "Hi! I am Ankit Mathur and I am currently a C# Developer. I have more than 2 years of experience in C# and Azure Development. Please reach out to me at ankit301095@gmail.com.";
        String aboutApp = "This is a basic calculator developed via Windows Form Application.";
        public Form1()
        {
            InitializeComponent();
        }

        private void button_num_click(object sender, EventArgs e)
        {
            enableOperators();
            if (textBoxResult.Text == "0" || isOperatorUsed)
                textBoxResult.Text="";

            isOperatorUsed = false;
            Button button = (Button)sender;
            //buttonNum = button.Text;
            if (isButtonEqualTo)
            {
                labelInputValue.Text = "";
                textBoxResult.Text = "";
                outputResult = 0;
                isButtonEqualTo = false;
            }
            if (button.Text == ".")
            {
                if(!textBoxResult.Text.Contains("."))
                    textBoxResult.Text = textBoxResult.Text + button.Text;
            }
            else
                textBoxResult.Text = textBoxResult.Text + button.Text;
            buttonNum = textBoxResult.Text;
            //isOperatorUsed = false;
        }

        private void opr_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isButtonEqualTo)
            {
                isOperatorUsed = true;
                operatorUsed = button.Text;
                labelInputValue.Text = textBoxResult.Text + " " + operatorUsed;
                //buttonValueEqualTo.PerformClick();
                isButtonEqualTo = false;
            }

            else if (outputResult != 0)
            {
                isOperatorUsed = true;
                buttonValueEqualTo.PerformClick();
                operatorUsed = button.Text;
                labelInputValue.Text += " " + buttonNum + " " + operatorUsed + " ";
            }
            else
            {
                isOperatorUsed = true;
                operatorUsed = button.Text;
                outputResult = Convert.ToDouble(textBoxResult.Text);
                if (isButtonEqualTo)
                    labelInputValue.Text = "";
                labelInputValue.Text = outputResult + " " + operatorUsed;
            }
        }

        private void EqualToOpr_click(object sender, EventArgs e)
        {
            if (isButtonEqualTo)
            {
                labelInputValue.Text = outputResult.ToString() + " " + operatorUsed;
            }
            switch (operatorUsed)
            {
                case "+":
                    textBoxResult.Text = (outputResult + Convert.ToDouble(buttonNum)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (outputResult - Convert.ToDouble(buttonNum)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (outputResult * Convert.ToDouble(buttonNum)).ToString();
                    break;
                case "/":
                    if(Convert.ToDouble(buttonNum) != 0)
                    {
                        textBoxResult.Text = (outputResult / Convert.ToDouble(buttonNum)).ToString();
                    }
                    else
                    {
                        textBoxResult.Text = "Cannot be divided by zero";
                        disableOperators();
                    }
                    break;
                default:
                    break;
            }
            try
            {
                outputResult = Convert.ToDouble(textBoxResult.Text);
            }
            catch { }
            //labelInputValue.Text = "";
            if (!isOperatorUsed)
            {
                labelInputValue.Text += " " + buttonNum + " " + buttonValueEqualTo.Text;
                isButtonEqualTo = true;
            }

        }

        private void buttonValueClearEntry_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            labelInputValue.Text = "";
            outputResult = 0;
            isOperatorUsed = false;
        }

        private void buttonValueClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void contextHelpStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //ContextMenuStrip contextMenuItem = sender as ContextMenuStrip;
            String contextMenuText = e.ClickedItem.Text;
            switch (contextMenuText)
            {
                case "About App":
                    MessageBox.Show(aboutApp,"About Calculator");
                    break;
                case "About Developer":
                    MessageBox.Show(aboutDeveloper, "About the Developer");
                    break;
                default:
                    break;
                       
            }

        }

        private void contextFileStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            String contextMenuText = e.ClickedItem.Text;
            switch (contextMenuText)
            {
                case "Exit":
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            String keyPressed = e.KeyChar.ToString();
            switch (keyPressed)
            {
                case "0":
                    buttonValue0.PerformClick();
                    break;
                case "1":
                    buttonValue1.PerformClick();
                    break;
                case "2":
                    buttonValue2.PerformClick();
                    break;
                case "3":
                    buttonValue3.PerformClick();
                    break;
                case "4":
                    buttonValue4.PerformClick();
                    break;
                case "5":
                    buttonValue5.PerformClick();
                    break;
                case "6":
                    buttonValue6.PerformClick();
                    break;
                case "7":
                    buttonValue7.PerformClick();
                    break;
                case "8":
                    buttonValue8.PerformClick();
                    break;
                case "9":
                    buttonValue9.PerformClick();
                    break;
                case "+":
                    buttonValueAdd.PerformClick();
                    break;
                case "-":
                    buttonValueSub.PerformClick();
                    break;
                case "*":
                    buttonValueMultiply.PerformClick();
                    break;
                case "/":
                    buttonValueDiv.PerformClick();
                    break;
                case "=":
                    buttonValueEqualTo.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void disableOperators()
        {
            foreach (Control c in Controls)
                {
                    //Button b = (Button)c;
                    if (c.Text=="+" || c.Text == "-" || c.Text == "*" || c.Text == "/")
                    {
                        c.Enabled = false;
                    }
                }
        }
        private void enableOperators()
        {
            foreach (Control c in Controls)
            {
                //Button b = (Button)c;
                if (c.Text == "+" || c.Text == "-" || c.Text == "*" || c.Text == "/")
                {
                    c.Enabled = true;
                }
            }
        }
    }
}
