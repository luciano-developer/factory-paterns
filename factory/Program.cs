using factory;

public class Program
{
    private static void Main(string[] args)
    {
        IAccount savingAccount = Factory.CreateObject(FactoryObjectEnum.SavingAccount);
        IAccount checkingAccount = Factory.CreateObject(FactoryObjectEnum.CheckingAccount);

        Console.WriteLine("Saving Account Interest Rate: " + savingAccount.InterestRate());
        Console.WriteLine("Checking Account Interest Rate: " + checkingAccount.InterestRate());

        Console.ReadLine();
    }
}