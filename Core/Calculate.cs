﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Calculate
    {
        public static void Main()
        { 
        
        }

        private string? Ffunc;
        private string? Gfunc;
        private string? RegisterSize;
        private string? InputX;
        private string? InputY;

        public Calculate(IItem items)
        { 
            Ffunc = items.Ffunc;
            Gfunc = items.Gfunc;
            RegisterSize = items.RegisterSize;
            InputX = items.InputX;
            InputY = items.InputY;
        }

        // with mistake
        //string expression = "x^2 - 2*y/x - 1";
        //expression = expression.Replace("x", "2");
        //expression = expression.Replace("y", "1,3");
        //Mather mather = new(expression);
        //Console.WriteLine(mather.Calc());

        //int n = 16;
        //double x = 12.7;
        //string res = Two(x, n);
        //double monna = Monna(res);
        //double rev = Reverse(res);

        //return;
            
        // correct.
        /// Перевод из double в 2-ичную строку. 
        string Two (double x, int n)
        {
            string zel = Convert.ToString(Convert.ToInt32(Math.Truncate(x)), 2);
            List<double> asd = new ();
            asd.Add(x - Math.Truncate(x));
            StringBuilder result = new(zel);
            result.Append('.');

            for (int i = 1; i <= n; i++)
            {
                double tmp = (2 * asd[i - 1]) - Math.Truncate(asd[i - 1] * 2);
                asd.Add(tmp);
                result.Append(Convert.ToInt32(Math.Truncate(asd[i - 1] * 2)));
            }

            return result.ToString();
        }

        //testing
        /// Отображение Монна 2-адического числа на отрезок [0,1] 
        double Monna(string output)
        {
            double result = 0;
            for (int i = 1; i < output.Length; i++)
            {
                if (output[i] != '.')
                {
                    result += int.Parse(output[i].ToString()) / Math.Pow(2, i);
                }
            }
            return result;
        }

        //testing
        /// Другое отображение 2-адического числа на отрезок [0,1] 
        double Reverse(string output)
        {
            double result = 0;
            for (int i = 1; i < output.Length; i++)
            {
                if (output[output.Length - i] != '.')
                {
                    result += int.Parse(output[output.Length - i].ToString()) / Math.Pow(2, i);
                }
            }
            return result;
        }
    }
}
