namespace abstract_factory;
public interface IAbstractFactory
{
    IAbstractProductA CreateProductA();
    IAbstractProductB CreateProductB();
}

public interface IAbstractProductA
{
    string UsefulFunctionA();
}

public interface IAbstractProductB
{
    string UsefulFunctionB();
    string AnotherUsefulFunctionB(IAbstractProductA collaborator);
}

public class ConcreteFactory1 : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ConcreteProductA1();
    }

    public IAbstractProductB CreateProductB()
    {
        return new ConcreteProductB1();
    }
}

public class ConcreteFactory2 : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ConcreteProductA2();
    }

    public IAbstractProductB CreateProductB()
    {
        return new ConcreteProductB2();
    }
}

class ConcreteProductA1 : IAbstractProductA
{
    public string UsefulFunctionA()
    {
        return "the result of product  A1";
    }
}

class ConcreteProductA2 : IAbstractProductA
{
    public string UsefulFunctionA()
    {
        return "the result of the product A2";
    }
}

class ConcreteProductB1 : IAbstractProductB
{
    public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
    {
        var result = collaborator.UsefulFunctionA();

        return $"the result of B1 collaborating with the ({result})";
    }

    public string UsefulFunctionB()
    {
        return "the result of product B1";
    }
}

class ConcreteProductB2 : IAbstractProductB
{
    public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
    {
        var result = collaborator.UsefulFunctionA();

        return $"the result of B2 collaborating with the ({result})";
    }

    public string UsefulFunctionB()
    {
        return "the result of product B2";
    }
}

class Client
{
    public void Main()
    {
        Console.WriteLine("Client: Testing client code with the first factory type...");
        ClientMethod(new ConcreteFactory1());

        Console.WriteLine("");

        Console.WriteLine("Client: Testing the same client code with the second factory type...");
        ClientMethod(new ConcreteFactory2());
    }

    public static void ClientMethod(IAbstractFactory factory)
    {
        var productA = factory.CreateProductA();
        var productB = factory.CreateProductB();

        Console.WriteLine(productB.UsefulFunctionB());
        Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
    }
}

class Program
{
    static void Main(string[] args)
    {
        new Client().Main();
    }
}

