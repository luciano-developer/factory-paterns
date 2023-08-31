public class PaymentCreditCard : Payment
{
    public PaymentCreditCard()
    {
        Type = "creditcard";
        Description = "payment by creditcard";
    }

    public override void Pay(double value)
    {
        Console.WriteLine("Paid by card, value :" + value);
    }
}