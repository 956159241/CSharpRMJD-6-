using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Ch11Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一行：创建一个数组类型，并使用
            //第二行：对Animal进行实例化此处的数组大小要根据内容设定，不然会报错
            //第三行：对Cow实例化，使用带参函数，体现出了面向对象开发的多态性
            //第四行：
            /*分别对数组对象复制，第一个将myCow1（一个对象，经过Cow实例化后得到的返回值） 
             *派生类（Cow）
             *  public Cow(string newName): base(newName){}
             *基类
             *  public Animal(string newName)
             *   {
             *       name = newName;
             *   }
             * 赋值给数组第一个变量
             * 结果：Deirdre
             */
            //第五行：
            /*
             *此处直接获得Chicken里的带一个参数的返回值对象
             * public Chicken(string newName): base(newName){}
             * 结果：Ken
             */
            Console.WriteLine("Create an Array type collection of Animal object and use it:");
            Animal[] animalArray = new Animal[2];
            Cow myCow1 = new Cow("Deirdre");
            animalArray[0] = myCow1;
            animalArray[1] = new Chicken("Ken");
            //第一行：使用迭代循环，并定义了myAnimal类型为Animal类型
            //第二行：输出myAnimal的类型和所带属性
            //第三行：输出animalArray数组长度
            //第四行：调用Animal自带的Feed（）函数
            //第五行：调用Chicken里的LayEgg（）方法，由于animalArray本来是Animal类型，所以调用Chicken的方法，要进行强制类型转换
            foreach (Animal myAnimal in animalArray)
            {
                Console.WriteLine("New {0} object added to Array collection Name = {1}", myAnimal.ToString(), myAnimal.Name);
            }
            Console.WriteLine("Array collection contains {0} objects.", animalArray.Length);
            animalArray[0].Feed();
            ((Chicken)animalArray[1]).LayEgg();
            Console.WriteLine();
            //第二个集合是System.Collection.ArrayList类
            Console.WriteLine("Create an ArrayList type collection of Animal objects and use it:");
            ArrayList animalArrayList = new ArrayList();
            Cow myCow2 = new Cow("Hayley");
            animalArrayList.Add(myCow2);
            animalArrayList.Add(new Chicken("Roy"));
            foreach (Animal myAnimal in animalArrayList)
            {
                Console.WriteLine("New {0} object added to ArrayList collection Name = {1}", myAnimal.ToString(), myAnimal.Name);
            }
            Console.WriteLine("ArrayList colleciton contains {0} objects.", animalArrayList.Count);
            ((Animal)animalArrayList[0]).Feed();
            ((Chicken)animalArrayList[1]).LayEgg();
            Console.WriteLine();
            //利用了一些ArrayList集合功能超出了Array集合的功能范围
            Console.WriteLine("Additional manipulation of ArrayList:");
            animalArrayList.RemoveAt(0);
            ((Animal)animalArrayList[0]).Feed();
            animalArrayList.AddRange(animalArray);
            ((Chicken)animalArrayList[2]).LayEgg();
            Console.WriteLine("The animal called{0} is at index {1}.", myCow1.Name, animalArrayList.IndexOf(myCow1));
            myCow1.Name = "Janice";
            Console.WriteLine("The animal is now called {0}.", ((Cow)animalArrayList[1]).Name);



            Console.ReadKey();

        }
    }
}
