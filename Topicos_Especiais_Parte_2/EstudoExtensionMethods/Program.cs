using EstudoExtensionMethods.Extensions;

namespace EstudoExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2024, 11, 22, 11, 20, 10);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
