using System;

namespace WithoutFactoryDP
{
    public class BMW : ICarSupplier
    {
        public string CarColor
        {
            get
            {
                return "WHITE";
            }
        }

        public void GetCarModel()
        {
            Console.WriteLine("Honda Car Model is Honda 2014");
        }
    }
}
