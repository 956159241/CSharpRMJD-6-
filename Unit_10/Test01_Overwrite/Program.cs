using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test01_Overwrite
{
    public class MyBaseClass
    {
        //virtual——方法可以重写
        public virtual void DoSomething()
        { 
            //Base implementation
        }
    }
    //Extends a class(MyBaseClass) and overwrite it's method
    //override——方法重写了一个基类方法（如果方法被重写，就必须使用该关键字）
    public class MyDerivedClass : MyBaseClass
    { 
        //To overwrite the method
        public override void DoSomething()
        { 
            //Drived class implementation,overrides base inplementation.
        }
    }

    public class MyTestClass : MyDerivedClass
    {
        public override void DoSomething()
        { 
            //this is test to see whether the method is rewritten
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
