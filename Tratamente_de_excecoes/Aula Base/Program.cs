namespace Aula_Base
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int result = n1 / n2;
                Console.WriteLine(result);
            } catch (DivideByZeroException e)
            {
                Console.WriteLine($"Error! {e.Message}");
            } catch (FormatException e)
            {
                Console.WriteLine($"Format Error! {e.Message}");
            } // bloco finally: fará um comando que acontecerá independete
              // do programa ter sido executado corretamente ou não.
        }
    }
}
