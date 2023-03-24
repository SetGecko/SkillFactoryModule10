namespace Task_10._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Writer writer = new Writer();
            ((IWriter)writer).Write();
        }
    }
    public interface IWriter
    {
        void Write();
    }
    public class Writer : IWriter
    {
        void IWriter.Write()
        {
            Console.WriteLine("Я пример явной реализации интерфейса");
        }
    }
}