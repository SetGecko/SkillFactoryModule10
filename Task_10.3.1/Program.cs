namespace Task_10._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public interface IWriter
    {
        void Write();
    }
    public interface IReader
    {
        void Read();
    }
    public interface IMailer
    {
        void SendMail();
    }
    class FileManager : IWriter, IReader, IMailer
    {
        public void Read()
        {
            Console.WriteLine("Читаем из файлов");
        }

        public void SendMail()
        {
            Console.WriteLine("Отправляем почту");
        }

        public void Write()
        {
            Console.WriteLine("Пишем в файл");
        }
    }
}