public class PizzaFactorySP : PizzaFactoryMethod
{
    public PizzaFactorySP()
    {
    }

    protected override Pizza? CriarPizza(TipoPizzaEnum tipo)
    {
        return tipo switch
        {
            TipoPizzaEnum.MUSSARELA => new PizzaMussarelaSP(),
            TipoPizzaEnum.CALABRESA => new PizzaCalabresaSP(),
            _ => null,
        };
    }
}