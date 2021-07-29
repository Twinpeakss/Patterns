using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class AmdRyzen : ICpu
    {
        public void Process()
        {
            Console.WriteLine("Ryzen processor start working...");
        }
    }
}