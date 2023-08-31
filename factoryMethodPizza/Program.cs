
PizzaFactoryMethod pizzaFactorySP = new PizzaFactorySP();

Pizza? pizzaSP = pizzaFactorySP.MontaPizza(TipoPizzaEnum.CALABRESA);

PizzaFactoryMethod pizzaFactoryRJ = new PizzaFactoryRJ();

Pizza? pizzaRJ = pizzaFactoryRJ.MontaPizza(TipoPizzaEnum.MUSSARELA);


Console.WriteLine(pizzaSP?.Preparar());
Console.WriteLine("");
Console.WriteLine(pizzaRJ?.Preparar());
Console.WriteLine("Fim processo");

Console.ReadKey();