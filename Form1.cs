using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        double memoryStored = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if ((txtDisplay.Text == "0") || (isOperationPerformed))
            {
                if (button.Text == ".")
                {
                    // If the first button clicked is the decimal, keep "0" and append a decimal point.
                    txtDisplay.Text = "0.";
                }
                else
                {
                    txtDisplay.Text = "";
                }

                isOperationPerformed = false;
            }
            else if (button.Text == "." && txtDisplay.Text.Contains("."))
            {
                // Do not allow more than one decimal point.
                return;
            }

            txtDisplay.Text += button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0 && !isOperationPerformed)
            {
                operationPerformed = button.Text;
                txtDisplay.Text = resultValue + " " + operationPerformed + " ";
                isOperationPerformed = true;
            }
            else if (txtDisplay.Text != "")
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(txtDisplay.Text);
                txtDisplay.Text = resultValue + " " + operationPerformed + " ";
                isOperationPerformed = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            resultValue = 0;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    txtDisplay.Text = (resultValue + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (resultValue - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (resultValue * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (resultValue / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "√":
                    txtDisplay.Text = (Math.Sqrt(Double.Parse(txtDisplay.Text))).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(txtDisplay.Text);
            operationPerformed = "";
        }

        private void btnMemorySave_Click(object sender, EventArgs e)
        {
            memoryStored = Double.Parse(txtDisplay.Text);
        }

        private void btnMemoryClear_Click(object sender, EventArgs e)
        {
            memoryStored = 0;
        }

        private void btnMemoryRead_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = memoryStored.ToString();
        }

        private void btnMemoryAdd_Click(object sender, EventArgs e)
        {
            memoryStored += Double.Parse(txtDisplay.Text);
            txtDisplay.Text = memoryStored.ToString();
        }

        private void btnMemorySubtract_Click(object sender, EventArgs e)
        {
            memoryStored -= Double.Parse(txtDisplay.Text);
            txtDisplay.Text = memoryStored.ToString();
        }
    }
}
