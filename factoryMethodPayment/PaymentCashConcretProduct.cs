public class PaymentCash : Payment
{
    public PaymentCash()
    {
        Type = "cash";
        Description = "payment by cash";
    }

    public override void Pay(double value)
    {
        Console.WriteLine("Paid by cash, value :" + value);
    }
}