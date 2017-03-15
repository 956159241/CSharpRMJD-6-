using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 传递的参数能否改变
{
    class Program
    {
        static void ChangeParameterMethod1(int value)
        {
            value = value * 2;
            Console.WriteLine("由定义函数输出：" + value);
        }
        static void ChangeParameterMethod2( ref int value)
        {
            value = value * 2;
            Console.WriteLine("由定义函数输出：" + value);
        }
        static void Main(string[] args)
        {
            int myValue1 = 3;
            ChangeParameterMethod1(myValue1);
            Console.WriteLine("由主函数输出，查看myValue是否改变：" + myValue1);

            int myValue2 = 3;
            ChangeParameterMethod2(ref myValue2);
            Console.WriteLine("由主函数输出，查看myValue是否改变：" + myValue2);
            Console.ReadLine();
        }
    }
}
