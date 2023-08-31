public abstract class Payment
{
    protected string? Description { get; set; }
    protected string? Type { get; set; }
    public abstract void Pay(double value);

}