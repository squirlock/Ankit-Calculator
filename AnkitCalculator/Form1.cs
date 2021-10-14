using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnkitCalculator
{
    public partial class AnkitCalculator : Form
    {

        Double outputResult = 0;
        String operatorUsed = "";
        bool isOperatorUsed = false;

        public AnkitCalculator()
        {
            InitializeComponent();
        }

        private void button_num_click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0" || isOperatorUsed)
                textBoxResult.Clear();

            isOperatorUsed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBoxResult.Text.Contains("."))
                    textBoxResult.Text = textBoxResult.Text + button.Text;
            }
            else
                textBoxResult.Text = textBoxResult.Text + button.Text;
        }

        private void opr_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (outputResult != 0)
            {
                buttonValueEqualTo.PerformClick();
                operatorUsed = button.Text;
                labelInputText.Text = outputResult + " " + operatorUsed;
                isOperatorUsed = true;
            }
            else
            {
                operatorUsed = button.Text;
                outputResult = Convert.ToDouble(textBoxResult.Text);
                labelInputText.Text = outputResult + " " + operatorUsed;
                isOperatorUsed = true;
            }
        }

        private void buttonValueClearEntry_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void buttonValueClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            labelInputText.Text = "";
            outputResult = 0;
            isOperatorUsed = false;
        }

        private void EqualToOpr_click(object sender, EventArgs e)
        {
            switch (operatorUsed)
            {
                case "+":
                    textBoxResult.Text = (outputResult + Convert.ToDouble(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (outputResult - Convert.ToDouble(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (outputResult * Convert.ToDouble(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (outputResult / Convert.ToDouble(textBoxResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            outputResult = Convert.ToDouble(textBoxResult.Text);
            labelInputText.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, I am Ankit Mathur. And this is a test calculator I made for learning" , "About Ankit's Calculator");
        }
    }
}
