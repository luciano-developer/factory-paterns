public abstract class PizzaFactoryMethod
{
    public Pizza? MontaPizza(TipoPizzaEnum tipo)
    {
        Pizza? pizza;
        pizza = CriarPizza(tipo);
        return pizza;
    }
    protected abstract Pizza? CriarPizza(TipoPizzaEnum tipo);
}