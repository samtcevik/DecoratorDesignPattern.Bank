using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDesignPattern.Bank.Operation
{
    public class EftAction : DecoratorAction
    {
        public override string Execute()
        {
            var textEft =  base.Execute() + " - EftAction";
            return textEft;
        }
    }
}
