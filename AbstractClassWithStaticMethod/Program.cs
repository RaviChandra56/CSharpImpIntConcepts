using System;

namespace AbstractClassWithStaticMethod
{
    class Program
    {
        /// <summary>
        /// Yes we can have Static Method in a Abstract class
        /// Because Static methods do not work on instance of the class, They are directly associated with the class itself
        /// the compiler can guarantee that an abstract method will have a real implementation any time that it is called, 
        /// because you can't create an instance of an abstract class
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            AbstractClass.StaticMethod();
            Console.ReadLine();
        }

        //OutPut = Abstract Class - Static Method
    }
}
