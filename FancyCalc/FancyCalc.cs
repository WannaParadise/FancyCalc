using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCalc
{
    public class FancyCalcEnguine
    {

        public double Add(int a, int b)
        {
          //  throw new NotImplementedException();
            return a + b;
        }


        public double Subtract(int a, int b)
        {
            //throw new NotImplementedException();
            return a - b;
        }


        public double Multiply(int a, int b)
        {
            return a * b;
        }

        //generic calc method. usage: "10 + 20"  => result 30
        public double Culculate(string expression)
        {
            expression = expression.Replace("  ", string.Empty);
            expression = expression.Trim().Replace(" ", string.Empty);
            double[] a = new double[expression.Length];
            double[] b = new double[expression.Length];
            char[] ax = new char[expression.Length];
            ax = expression.ToCharArray();
            string oper = "";
            int operaind = 5;
            for (int i = 0; i < expression.Length; i++)

            {
                if (char.IsDigit(ax[i]))
                {
                    a[i] = (int)Char.GetNumericValue(ax[i]);

                }
                else
                {
                    oper = ax[i].ToString();
                    operaind = i;
                    break;
                }
            }
            for (int i = operaind + 1; i < expression.Length; i++)

            {
                if (char.IsDigit(ax[i]))
                {
                    b[i] = (int)Char.GetNumericValue(ax[i]);

                }
                else
                {
                    break;
                }
            }

            Array.Resize(ref a, operaind);
            string a1 = string.Join("", a);
            string b1 = string.Join("", b);
            double first = Convert.ToDouble(a1);
            double second = Convert.ToDouble(b1);
            double finish = 0;
            switch (oper)
            {
                case "+":
                    finish = first + second;
                    break;

                case "-":
                    finish = first - second;
                    break;
                case "*":
                    finish = first * second;
                    break;
                default:
                    break;
            }
            return finish;


        }
    }
}
