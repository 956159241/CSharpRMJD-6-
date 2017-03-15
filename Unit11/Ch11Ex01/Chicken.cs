using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch11Ex01
{
    public class Chicken : Animal
    {
        //Chicken类中定义了两个方法，一个是自定义，一个是利用base引用基类函数
        public void LayEgg()
        {
            Console.WriteLine("{0} has laid an egg.",name);
        }
        public Chicken(string newName)
            : base(newName)
        {

        }
    }
}
