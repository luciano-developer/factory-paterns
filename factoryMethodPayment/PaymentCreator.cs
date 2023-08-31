public abstract class PaymentCreator
{
    public abstract Payment FactoryMethod(PaymentTypeEnum typePaymentEnum);
}

public enum PaymentTypeEnum
{
    CREDITCARD,
    CASH
}