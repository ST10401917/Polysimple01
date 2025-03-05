using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polysimple01 /* method overridng happens when a subclass 
                        * provides a specific implementation of a method that is already defined in its base classs */
{


    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }



    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Dog(); // parent class reference holding a child class object
            myAnimal.MakeSound(); // calls Dog's MakeSound() method
        }
    }
}
