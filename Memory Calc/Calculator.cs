using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Calc
{
    class Calculator
    {


        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }



        public static void Negate(TextBox Inside) //negate method
        {
            string num = Convert.ToString(Inside.Text);
            string negate = "";

            if (num.StartsWith("-")) { negate = num.Trim('-'); }
            else { negate = "-" + num; }

            Inside.Text = Convert.ToString(negate);
        }

        public static void Exponent(TextBox Inside) //exponent method
        {
            decimal num2 = Convert.ToDecimal(Inside.Text);
            decimal exponent = 1 / num2;
            Inside.Text = Convert.ToString(exponent);
        }

        public static void Squareroot(TextBox Inside) //square root method
        {
            double num3 = Convert.ToDouble(Inside.Text);
            double sqrt = Math.Sqrt(num3);
            Inside.Text = Convert.ToString(sqrt);
        }

        public static void Back(TextBox Inside) //back button
        {
            string num4 = Convert.ToString(Inside.Text);
            string back = num4.Remove(num4.Length - 1);
            Inside.Text = Convert.ToString(back);
        }

    }
}
