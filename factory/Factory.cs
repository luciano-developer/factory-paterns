using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace factory;

public static class Factory
{
    public static IAccount? CreateObject(FactoryObjectEnum factoryObject)
    {
        IAccount? account = null;

        switch (factoryObject)
        {
            case FactoryObjectEnum.SavingAccount:
                account = new SavingAccount();
                break;
            case FactoryObjectEnum.CheckingAccount:
                account = new CheckingAccount();
                break;
            default:
                break;

        }

        return account;
    }
}