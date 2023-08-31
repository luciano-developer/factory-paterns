using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace factory;

public class CheckingAccount : IAccount
{
    public string Withdraw(int amount)
    {
        throw new NotImplementedException();
    }
    public string Deposit(int amount)
    {
        throw new NotImplementedException();
    }
    public double InterestRate()
    {
        return 10.24;
    }
}