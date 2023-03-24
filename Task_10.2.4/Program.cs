namespace Task_10._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            ((IWorker)worker).Build();
        }
    }
    public interface IWorker
    {
        public void Build();
    }
    public class Worker : IWorker
    {
        void IWorker.Build()
        {
            Console.WriteLine("Явно реализованный интерфейс IWorker");
        }
    }
}