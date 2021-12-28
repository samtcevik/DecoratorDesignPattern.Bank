using DecoratorDesignPattern.Bank.Operation;
using System;

namespace DecoratorDesignPattern.Bank.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            DecoratorAction efAction = new EftAction();
            DecoratorAction havaleAction = new HavaleAction();

            Console.WriteLine(efAction.Execute());
            Console.WriteLine(havaleAction.Execute());
        }
    }
}
