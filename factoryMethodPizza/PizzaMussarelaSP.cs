public class PizzaMussarelaSP : Pizza
{
    public PizzaMussarelaSP()
    {
        Nome = "Pizzq de mussarela SP";
        Massa = "Massa fina crocante paulista";
        Molho = "Molho de tomate italiano paulista";
        AdicionarIgrediente("Queijo parmesão");
        AdicionarIgrediente("Azeitona verde");
    }
}