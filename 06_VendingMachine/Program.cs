using System;

namespace _06_VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vm = new AnimalFeedVendingMachine();
            Console.WriteLine(vm.Dispense(2.00M));
            //vm.CheckAmount(1F);
        }
    }
}
