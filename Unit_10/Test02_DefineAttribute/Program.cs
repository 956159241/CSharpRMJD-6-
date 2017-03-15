using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test02_DefineAttribute
{
    public class MyTestClass
    { 
        //Field used by prtperty
        private int myInt;
        //Property
        public int MyIntProp
        {
            get
            {
                return myInt;
            }
            set
            {
                myInt = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
