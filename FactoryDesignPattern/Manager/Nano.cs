using System;

namespace FactoryDesignPattern.Manager
{
    public class Nano : ICarSupplier
    {
        public string CarColor
        {
            get
            {
                return "RED";
            }
        }

        public void GetCarModel()
        {
            Console.WriteLine("Nano Car Model is Nano 2014");
        }
    }
}
