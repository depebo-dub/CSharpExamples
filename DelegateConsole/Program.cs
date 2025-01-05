namespace DelegateConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Hello(string a) => Console.WriteLine("Hello METANIT.COM" + a);

            Hello("sdfg");


            Console.WriteLine("1");
        }
    }
}
