namespace StrategyPattern
{
    public class Context
    {
        public ICpu Cpu { get; set; }

        protected CardType Card;

        protected int RamMemory;

        public Context(CardType cardType, int memory, ICpu cpu)
        {
            Cpu = cpu;
            Card = cardType;
            RamMemory = memory;
        }

        public void ExecuteProccesing()
        {
            Cpu.Process();
        }
    }
}