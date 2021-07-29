using System;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var computer = new Context(CardType.GeForce, 16, new AmdRyzen());
            computer.ExecuteProccesing();

            Task.Delay(1000);

            var computer_2 = new Context(CardType.AmdRadeon, 8, new IntelCore());

            computer_2.ExecuteProccesing();

            Console.Read();
        }
    }
}