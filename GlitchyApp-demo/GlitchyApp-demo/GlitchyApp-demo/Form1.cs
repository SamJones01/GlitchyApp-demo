using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlitchyApp_demo
{
    public partial class Calculator : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double output = 0.0;

        public Calculator()
        {
            InitializeComponent();
        }

        //add 0 to input then add to the calc line
        private void zero_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += 0;
            textBox1.Text = input;
        }

        private void point_Click(object sender, EventArgs e)
        {
            //if the string contains . then do not add another
            if(input.Contains('.'))
            {

            }
            else
            //add a . to the string
            {
                textBox1.Text = "";
                input += '.';
                textBox1.Text = input;
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if(operation == '+')
            {
                double result = num1 + num2;
                textBox1.Text = result.ToString();
            }

            if(operation == '*')
            {
                double result = num1 * num2;
                textBox1.Text = result.ToString();
            }

            if(operation == '-')
            {
                double result = num1 - num2;
                textBox1.Text = result.ToString();
            }

            if(operation == '/')
            {
                if(num2!=0)
                {
                    double result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "Math ERROR";
                }
            }
        }

        //add 1 to input then add to the calc line
        private void one_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += 1;
            textBox1.Text = input;
        }

        //add 2 to input then add to the calc line
        private void two_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += 2;
            textBox1.Text = input;
        }

        //add 3 to input then add to the calc line
        private void three_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += 3;
            textBox1.Text = input;
        }

        //add / to operation and clear the calc line
        private void divide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        //ad 4 to input then add to the calc line
        private void four_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += 4;
            textBox1.Text = input;
        }

        //add 5 to input then add to the calc line
        private void five_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += 5;
            textBox1.Text = input;
        }

        //add 6 to input then add to the calc line
        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += 6;
            textBox1.Text = input;
        }

        //add 7 to input then add to the calc line
        private void seven_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += 7;
            textBox1.Text = input;
        }

        //add 8 to input then add to the calc line
        private void eight_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += 8;
            textBox1.Text = input;
        }

        //add 9 to input then add to the calc line
        private void nine_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input += 9;
            textBox1.Text = input;
        }

        //add * to operation and clear the calc line
        private void multiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        //add + to operation and clear the calc line
        private void button13_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        //clear the line and all variables so the new equation can start fresh
        private void delete_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }

        //add - to operation and clear the calc line
        private void subtract_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }
    }
}
