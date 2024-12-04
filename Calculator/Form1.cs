using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class btnconvert : Form
    {
        double firstNumber = 0;
        double secondNumber = 0;
        string operation = "";
        public btnconvert()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += 9;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(lblDisplay.Text);
            operation = "+";
            lblDisplay.Text = "";
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(lblDisplay.Text);
            operation = "-";
            lblDisplay.Text = "";
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(lblDisplay.Text);
            operation = "*";
            lblDisplay.Text = "";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(lblDisplay.Text);
            operation = "/";
            lblDisplay.Text = "";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblDisplay.Text))
            {
                MessageBox.Show("Please enter a number");
                return;
            }



            secondNumber = double.Parse(lblDisplay.Text);
            double result = 0;
            if (operation == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (operation == "-")
            {
                result = firstNumber - secondNumber;
            }
            else if (operation == "*")
            {
                result = firstNumber * secondNumber;
            }
            else if (operation == "/")
            {
                result = firstNumber / secondNumber;
            }

            lblDisplay.Text = result.ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += 0;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void inputtxt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = inputtxt1.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("enter a number");
            }
            else if (!float.TryParse(input, out float dollar))
            {
                MessageBox.Show("enter a number");
            }

            else
            {
                float result = dollar * 84.73f;
                lblinr.Text = result.ToString("F2");
            }
        }

        private void btnmilescon_Click(object sender, EventArgs e)
        {
            string input = milesinput.Text;
            
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("enter a number");
            }
            else if(!float.TryParse(input, out float kms))
            {
                MessageBox.Show("enter a number");
            }
            else
            {
                float result = kms *  1.60934f;
                lblkms.Text = result.ToString("F2");
            }
        }

        private void tokms_Click(object sender, EventArgs e)
        {

        }
    }
}
