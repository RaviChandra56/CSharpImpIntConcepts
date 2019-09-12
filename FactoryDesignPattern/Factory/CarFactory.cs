using FactoryDesignPattern.Manager;

namespace FactoryDesignPattern.Factory
{
    public static class CarFactory
    {
        public static ICarSupplier GetCarInstance(int Id)
        {
            switch (Id)
            {
                case 0:
                    return new Honda();
                case 1:
                    return new BMW();
                case 2:
                    return new Nano();
                case 3:
                    return new Suzuki();
                default:
                    return null;
            }
        }
    }
}
