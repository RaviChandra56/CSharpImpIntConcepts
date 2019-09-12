using System;

namespace FactoryDesignPattern.Manager
{
    public class Honda : ICarSupplier
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
            Console.WriteLine("Honda Car Model is Honda 2014");
        }
    }
}
