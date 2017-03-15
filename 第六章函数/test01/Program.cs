using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test01
{
    class Program
    {
        static double GetVal(int n) 
        {
            if (n > 5)
            {
                return 5;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetVal(x));
            Console.ReadLine();
        }
    }
}
