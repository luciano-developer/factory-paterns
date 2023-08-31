namespace FactoryCar;

public interface ICar
{
    string Name { get; }
}

public class Sedan : ICar
{
    public string Name => "Sedan";
}

public class Suv : ICar
{
    public string Name => "SUV";
}

public interface ICarFactory
{
    ICar CreateCar();
}

public class SedanFactory : ICarFactory
{
    public ICar CreateCar()
    {
        return new Sedan();
    }
}

public class SuvFactory : ICarFactory
{
    public ICar CreateCar()
    {
        return new Suv();
    }
}

public class Client
{
    public Client(ICarFactory factory)
    {
        ICar car = factory.CreateCar();
        Console.WriteLine($"Created a {car.Name}");
    }
}