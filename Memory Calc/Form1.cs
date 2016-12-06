using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Double value = 0; //initializing variables
        String operation = "";
        bool operation_Pressed = false; //key press 
        Double valueMemory = 0;
        Memory memoryCalc = new Memory(); //bringing forth memory calculator part

        private void button_Click(object sender, EventArgs e) //handles numbers/decimal
        {
            if ((txtAnswer.Text == "0")||(operation_Pressed)) //on every number/decimal, if nothing/operator hit
                txtAnswer.Clear(); //clear answer
            operation_Pressed = false; 
            Button b1 = (Button)sender; //store pressed button (b1)
            if (b1.Text == ".") //button is "." 
            {
                if (!txtAnswer.Text.Contains("."))
                    txtAnswer.Text = txtAnswer.Text + b1.Text; //adds there if not there already
            }
            else

                txtAnswer.Text = txtAnswer.Text + b1.Text; //adds button press text to answer
        }

        private void operator_Click(object sender, EventArgs e) //handles operators (+, -, *, /)
        {
            Button b2 = (Button)sender; //store pressed button (b2)
            operation = b2.Text; //string 
            value = Double.Parse(txtAnswer.Text); //parses number in text field
            operation_Pressed = true; //switches to true
            equation.Text = value + " " + operation; //value + operation = equation
        }

        private void btnEquals_Click(object sender, EventArgs e) //equals button
        {
            equation.Text = ""; //set to blank
            //Button b2 = (Button)sender;
            //operation = b2.Text;
            //value = Double.Parse(txtAnswer.Text); //parses number in text field
            //operation_Pressed = true;


            //) 
            //{
            //    txtAnswer.Text = Calculator.Plus(value, Double.Parse(txtAnswer.Text)).ToString(); //calling on Calculator class 
            //}
            //Attempt to try if/else statement
            switch (operation) //equations for each operator (+, -, *, /)
            {
                case "+":
                    txtAnswer.Text = Calculator.Add(value, Double.Parse(txtAnswer.Text)).ToString(); //calling on Calculator class
                    break; //for addition
                case "-":
                    txtAnswer.Text = Calculator.Subtract(value, Double.Parse(txtAnswer.Text)).ToString();
                    break; //for subtraction
                case "*":
                    txtAnswer.Text = Calculator.Multiply(value, Double.Parse(txtAnswer.Text)).ToString();
                    break; //for multiplication
                case "/":
                    txtAnswer.Text = Calculator.Divide(value, Double.Parse(txtAnswer.Text)).ToString();
                    break; //for division
            }
            value = Double.Parse(txtAnswer.Text);
        }

        private void btnNegate_Click(object sender, EventArgs e) //negate button 
        {
            Calculator.Negate(txtAnswer); //calling calculator negate function to textbox
        }

        private void btnSqrt_Click(object sender, EventArgs e) //square root button
        {
            Calculator.Squareroot(txtAnswer); //calling calculator square root function to textbox
        }

        private void btnRec_Click(object sender, EventArgs e) //exponent button
        {
            Calculator.Exponent(txtAnswer); //calling calculator exponent (1/X) function to textbox
        }

        private void btnBack_Click(object sender, EventArgs e) //back button
        {
            Calculator.Back(txtAnswer); //calling calculator back function to erase last integer
        }

        private void btnMemClear_Click(object sender, EventArgs e) //memory clear button
        {
            txtMem.Text = ""; //clear textbox and memory textbox
            valueMemory = 0;
        }
        //each memory method calling from Memory class
        private void btnMemRe_Click(object sender, EventArgs e)
        {
            memoryCalc.saveMem(valueMemory);
            txtMem.Text = valueMemory.ToString();
        }

        private void btnMemSave_Click(object sender, EventArgs e)
        {
            valueMemory = Double.Parse(txtAnswer.Text);
            memoryCalc.saveMem(valueMemory);
            txtMem.Text = "M";
        }

        private void btnMemPlus_Click(object sender, EventArgs e)
        {
            memoryCalc.saveMem(valueMemory);
            txtAnswer.Text = valueMemory.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e) //standard clear button
        {
            txtAnswer.Text = "0"; //clear all text from textboxes, default to 0
            equation.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e) //exit button
        {
            this.Close(); //close app
        }
    }
}
