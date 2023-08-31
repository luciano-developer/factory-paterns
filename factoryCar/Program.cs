
using FactoryCar;

Client sedan = new(new SedanFactory());
Client suv = new(new SuvFactory());

Console.ReadKey();
