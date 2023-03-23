namespace PracticeInterface_10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var writer = new IWriter();
        }
    }
    public interface IWriter
    {
        void Write() { Console.WriteLine("Привет, я Writer!"); }
    }
    public interface ILogger
    {
        void Write() { Console.WriteLine("Привет, я Logger!"); }
    }
    public class Writer: IWriter, ILogger
    {

    }
}