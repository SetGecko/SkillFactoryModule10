namespace Practice_10._3
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
            throw new NotImplementedException();
        }

        public void SendMail()
        {
            throw new NotImplementedException();
        }

        public void Write()
        {
            throw new NotImplementedException();
        }
    }
}