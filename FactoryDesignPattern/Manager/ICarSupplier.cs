namespace FactoryDesignPattern.Manager
{
    public interface ICarSupplier
    {
        string CarColor { get; }
        void GetCarModel();
    }
}
