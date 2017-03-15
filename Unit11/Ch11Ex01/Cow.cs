using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch11Ex01
{
    //Define a class(Cow)to extend Animal
    class Cow : Animal
    {
        //Define a method to describe animals' actions
        public void Milk()
        {
            Console.WriteLine("{0} has been milked.",name);
        }
        //base关键字指定.NET实例化过程使用基类中具有指定参数的构造函数。
        public Cow(string newName)
            : base(newName)
        { 
        
        }
    }
}
