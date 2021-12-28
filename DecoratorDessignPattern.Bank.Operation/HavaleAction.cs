using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.Bank.Operation
{
    public class HavaleAction : DecoratorAction
    {
        public override string Execute()
        {
            var havaleText = base.Execute() + " - HavaleAction";
            return havaleText;
        }
    }
}
