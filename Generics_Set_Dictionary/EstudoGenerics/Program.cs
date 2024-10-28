//Problema motivador 1 (reuso)

/*
 * Deseja-se fazer um programa que leia um conjunto de N números inteiros (N de
 * 1 a 10), e depois imprima esses números de forma organizada conforme exemplo. 
 * Em seguida, informar qual foi o primeiro valor informado.
*/

using EstudoGenerics.Services;

namespace EstudoGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();

            Console.WriteLine("First: " + printService.First());
        }
    }
}
