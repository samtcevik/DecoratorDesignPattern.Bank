using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace DecoratorDesignPattern.Bank.Operation
{
    public abstract class DecoratorAction : IAction
    {
        public virtual string Execute()
        {
            var text = "DecoratorAction çalıştırıldı.";
            return text;
        }
    }
}
