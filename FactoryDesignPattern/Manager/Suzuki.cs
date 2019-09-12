using System;

namespace FactoryDesignPattern.Manager
{
    public class Suzuki : ICarSupplier
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
            Console.WriteLine("Suzuki Car Model is Suzuki 2014");
        }
    }
}
