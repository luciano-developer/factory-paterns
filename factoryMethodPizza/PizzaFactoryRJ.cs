public class PizzaFactoryRJ : PizzaFactoryMethod
{
    public PizzaFactoryRJ()
    {
    }

    protected override Pizza? CriarPizza(TipoPizzaEnum tipo)
    {
        return tipo switch
        {
            TipoPizzaEnum.MUSSARELA => new PizzaMussarelaRJ(),
            TipoPizzaEnum.CALABRESA => null,
            _ => null,
        };
    }
}