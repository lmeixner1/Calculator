using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSM.Calc2.UI
{
    public class Calculator
    {
        public double add (double num1, double num2)
        { return num1 + num2; }

        public double subtract (double num1, double num2) 
        { return num1 - num2; }

        public double multiply (double num1, double num2) 
        { return num1 * num2; }

        public double divide(double num1, double num2)
        {
            double result = 0;
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("You cannot divide by zero, Rip bozo"); 
                    
            }
            return result;
        }

        public double sqrt (double num1)
        {
            return Math.Sqrt(num1);
        }

        public double reciprocal(double num1)
        {
            double result = 0;
            try
            {
                result = 1 / num1;
            }
            catch (DivideByZeroException ed)
            {
                MessageBox.Show("You cannot divide by zero, Rip bozo", ed.Message);

            }
            return result;
        }

        public double sign(double num)
        {
            return num *= -1;
        }
    }
}
