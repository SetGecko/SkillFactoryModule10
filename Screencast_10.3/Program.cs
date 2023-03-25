namespace Screencast_10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public interface IFile
    {
        void ReadFile();
    }
    public interface IBinaryFile
    {
        void ReadFile();
        void OPenBinaryFile();
    }
    class FileInfo : IFile, IBinaryFile
    {
        void IBinaryFile.OPenBinaryFile()
        {
            Console.WriteLine("Открываем бинарный файл");
        }

        void IFile. ReadFile()
        {
            Console.WriteLine("Читаем текстовыый файл");
        }
        void IBinaryFile.ReadFile()
        {
            Console.WriteLine("Читаем бинарный файл");
        }
        public void Search(string text)
        {
            Console.WriteLine("Начался поиск текста в файле");
        }
    }
}