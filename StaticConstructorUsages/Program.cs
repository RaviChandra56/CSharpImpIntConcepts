using System;

namespace StaticConstructorUsages
{
    class Program
    {
        /// <summary>
        /// Static constructor is used to initialize static data members as soon as class is reffered the first time.
        /// Diff between static and Singleton
        /// Static is a keyword / Singleton is a design pattern
        /// Static classes can contain only static members / Singleton is object creational pattern with only one instance
        /// Singleton supports object displosal
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            StaticConstructor.SomeMethod();
            StaticConstructor.empId++;
            StaticConstructor.empId++;
            StaticConstructor.empId++;
            StaticConstructor.SomeMethod();
            Console.WriteLine(StaticConstructor.empId.ToString());
            Console.ReadLine();
        }
    }
}
