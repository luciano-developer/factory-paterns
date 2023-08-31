public class PizzaMussarelaRJ : Pizza
{
    public PizzaMussarelaRJ()
    {
        Nome = "Pizzq de mussarela RJ";
        Massa = "Massa tradicional carioca";
        Molho = "Molho de tomate italiano carioca";
        AdicionarIgrediente("Queijo parmesão ralado");
        AdicionarIgrediente("Azeitona preta");
    }
}