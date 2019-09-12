using System;

namespace FactoryDesignPattern.Manager
{
    public class BMW : ICarSupplier
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
            Console.WriteLine("BMW Car Model is BMW 2014");
        }
    }
}
