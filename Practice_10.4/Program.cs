namespace Practice_10._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMessenger<Phone> viberInPhone = new Viber<Phone>();
            viberInPhone.GetDeviceInfo(new Phone());

            IMessenger<IPhone> viberInIphone = new Viber<IPhone>();
            viberInIphone.GetDeviceInfo(new IPhone());
        }
    }
    public interface IMessenger< out T>
    {
        T DeviceInfo();
    }
    public class Phone { }
    public class Computer { }
    public class Viber<T> : IMessenger<T> where T : Phone,
    new()
    {
        public T DeviceInfo()
        {
            T device = new T();
            Console.WriteLine(device);
            return new T();
        }
    }
    public class IPhone : Phone { }
}