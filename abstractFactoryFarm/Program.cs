

using FactoryFarm;

Client client = new(new VegetableFarm());

Console.WriteLine("");

Client client1 = new(new PoutryFarm());

Console.ReadKey();
