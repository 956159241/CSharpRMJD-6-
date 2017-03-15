using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 区分类和结构
{
    //定义一个类
    class MyClass
    {
        public int val; 
    }
    //定义一个结构，注意命名规则
    struct myStruct
    {
        public int val;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //对定义的类实例化
            MyClass objectA = new MyClass();
            //此处实际上是复制了这个地址
            MyClass objectB = objectA;
            objectA.val = 20;
            objectB.val = 30;
            //对结构进行实例化
            myStruct structA = new myStruct();
            //此处赋值的是结构体的所有信息
            myStruct structB = structA;
            structA.val = 20;
            structB.val = 30;
            //输出上面的四个值
            Console.WriteLine("objectA.val = {0}",objectA.val);
            Console.WriteLine("objectB.val = {0}", objectB.val);
            Console.WriteLine("structA.val = {0}", structA.val);
            Console.WriteLine("structB.val = {0}", objectB.val);


            Console.ReadKey();
        }
    }
}
