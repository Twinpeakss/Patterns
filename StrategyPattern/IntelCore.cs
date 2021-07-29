using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class IntelCore : ICpu
    {
        public void Process()
        {
            Console.WriteLine("Intelcore processor start working...");
        }
    }
}