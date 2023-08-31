public class PizzaCalabresaSP : Pizza
{
    public PizzaCalabresaSP()
    {
        Nome = "Pizza de calabresa SP";
        Massa = "Massa fina crocante ";
        Molho = "Molho de tomate italiano ";
        AdicionarIgrediente("Fatias de calabresa defumada");
        AdicionarIgrediente("Cebola");
        AdicionarIgrediente("Queijo");
    }
}