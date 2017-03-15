using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch11Ex01
{
    //Define a abstract class Animal
    public abstract class Animal
    {
        //protected ,to access the domain in the class(Animal) or in a class extends the class(Animal) 
        protected string name;
        public string Name  //attention please,the capital of Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        //To define a method
        public Animal()
        {
            name = "The animal with no name";
        }
        //To define a method with parameter
        public Animal(string newName)
        {
            name = newName;
        }
        //To define a method without returned value
        public void Feed()
        {
            Console.WriteLine("{0} has been fed.",name);
        }
    }
}
