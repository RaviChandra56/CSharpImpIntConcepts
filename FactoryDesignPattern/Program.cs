using FactoryDesignPattern.Factory;
using FactoryDesignPattern.Manager;
using System;

namespace FactoryDesignPattern
{
    class Program
    {
        /// <summary>
        /// The Factory method is a creational design pattern which provides an interface for creating 
        /// objects without specifying their concrete classes. 
        /// It defines a method which we can use to create an object instead of using its constructor. 
        /// The important thing is that the subclasses can override this method and create objects of different types.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ICarSupplier objCarSupplier = CarFactory.GetCarInstance(2);
            if (objCarSupplier != null)
            {
                objCarSupplier.GetCarModel();
                Console.WriteLine("And Coloar is " + objCarSupplier.CarColor);
            }
            else
            {
                Console.WriteLine("Car not exists");
            }


            Console.ReadLine();
        }
    }
}
