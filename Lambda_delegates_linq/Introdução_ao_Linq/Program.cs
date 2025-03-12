using System.Linq;

namespace Introdução_ao_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source (fonte de dados)
            int[] numbers = new int[] { 2, 3, 4 ,5 };

            // Define the query expression (manipulação de dados)
            var result = numbers
                .Where(EvenNumber)
                .Select(x => x * 10);

            // Execute the query (execução dos dados)
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
        static bool EvenNumber(int n)
        {
            return n % 2 == 0;
        }
    }
}
