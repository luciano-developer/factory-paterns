using System.Collections;
using System.Text;
public abstract class Pizza
{
    protected string? Nome { get; set; }
    protected string? Massa;
    protected string? Molho;
    private ArrayList? Ingredientes = new();

    protected void AdicionarIgrediente(string ingrediente)
    {
        Ingredientes?.Add(ingrediente);
    }
    public string Preparar()
    {

        StringBuilder stringBuilder = new();

        stringBuilder.Append($"Preparando {Nome} \n");
        stringBuilder.Append($"{Massa} \n");
        stringBuilder.Append($"{Molho} \n");
        stringBuilder.Append($"Ingredientes: ");
        Array.ForEach(Ingredientes!.ToArray(), ingrediente => stringBuilder.Append($"{ingrediente} \n"));
        stringBuilder.Append(Cozinhar());
        stringBuilder.Append(Fatiar());

        return stringBuilder.ToString();
    }

    public virtual string Cozinhar()
    {
        return "Cozinhar por 25 minutos \n";
    }

    public virtual string Fatiar()
    {
        return "Fatiar em 8 pedaços";
    }

    public virtual string Embalar()
    {
        return "Embalar";
    }
}