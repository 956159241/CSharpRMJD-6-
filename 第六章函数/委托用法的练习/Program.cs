using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 委托用法的练习
{
    class Program
    {
        delegate double ProcessDelegate(double param1,double param2);//委托声明(类似函数)
        static double Multiply(double param1, double param2)
        {
            return param1 * param2;
        }
        static double Divide(double param1, double param2)
        {
            return param1 / param2;
        }
        static void Main(string[] args)
        {
            ProcessDelegate process;
            Console.WriteLine("Enter 2 numbers separated with a comma:");
            string input = Console.ReadLine();
            int commaPos = input.IndexOf(',');
            double param1 = Convert.ToDouble(input.Substring(0,commaPos));
            double param2 = Convert.ToDouble(input.Substring(commaPos + 1,input.Length -1-commaPos));
            Console.WriteLine("Enter M to Multiply or D to Divide:");
            input = Console.ReadLine();
            //如果选M则调用函数Multiply否则使用函数Divide
            if (input == "M")
            {
                process = new ProcessDelegate(Multiply);
            }
            else
            {
                process = new ProcessDelegate(Divide);
            }
            Console.WriteLine("Result:{0}",process(param1,param2));
            Console.ReadLine();
        }
    }
}
