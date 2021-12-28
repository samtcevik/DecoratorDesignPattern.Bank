using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace DecoratorDesignPattern.Bank.Operation
{
    public interface IAction
    {
        public string Execute();
    }
}
