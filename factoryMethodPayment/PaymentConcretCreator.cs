public class PaymentConcretCreator : PaymentCreator
{
    public PaymentConcretCreator()
    {
    }

    public override Payment FactoryMethod(PaymentTypeEnum paymentType)
    {
        return paymentType switch
        {
            PaymentTypeEnum.CREDITCARD => new PaymentCreditCard(),
            PaymentTypeEnum.CASH => new PaymentCash(),
            _ => throw new ArgumentNullException(nameof(paymentType))
        };
    }
}