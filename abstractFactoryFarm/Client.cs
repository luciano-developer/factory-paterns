namespace FactoryFarm;

public class Client
{
    public Client(IFarmFactory farmFactory)
    {
        var plant = farmFactory.CreatePlant();
        Console.WriteLine(plant.Grow());

        var animal = farmFactory.CreateAnimal();
        Console.WriteLine(animal.Feed());
    }
}

public interface IPlant
{
    string Grow();
}

public class Potato : IPlant
{
    public string Grow()
    {
        return "Growing a potato.";
    }
}

public class Tomato : IPlant
{
    public string Grow()
    {
        return "Growing a tomato";
    }
}

public interface IAnimal
{
    string Feed();
}

public class Cow : IAnimal
{
    public string Feed()
    {
        return "Feeding a cow.";
    }
}

public class Chicken : IAnimal
{
    public string Feed()
    {
        return "Feeding a chicken.";
    }
}

public interface IFarmFactory
{
    IPlant CreatePlant();
    IAnimal CreateAnimal();
}

public class VegetableFarm : IFarmFactory
{
    public IAnimal CreateAnimal()
    {
        return new Cow();
    }

    public IPlant CreatePlant()
    {
        return new Potato();
    }
}

public class PoutryFarm : IFarmFactory
{
    public IAnimal CreateAnimal()
    {
        return new Chicken();
    }

    public IPlant CreatePlant()
    {
        return new Tomato();
    }
}