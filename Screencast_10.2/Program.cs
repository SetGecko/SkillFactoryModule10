namespace Screencast_10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public interface ICalculator
    {
        void Solve(int number);
        void Solve(int numberOne, int numberTwo);
    }
    public class BaseCalculator : ICalculator
    {
        void ICalculator.Solve(int number)
        {
            
        }

        void ICalculator.Solve(int numberOne, int numberTwo)
        {
            
        }
    }
}