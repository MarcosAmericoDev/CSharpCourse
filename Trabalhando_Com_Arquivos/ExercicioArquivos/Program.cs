using ExercicioArquivos.Entities;
using System.Globalization;

namespace ExercicioArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourceFilePath = @"c:\temp\source.csv";

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                Console.WriteLine(targetFolderPath);

                using (StreamWriter sr = File.AppendText(targetFilePath)) 
                {
                    foreach(string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Produto p = new Produto(name, price, quantity);

                        sr.WriteLine(p.Name + "," + p.TotalPrice().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            } 
            catch(IOException e)
            {
                Console.WriteLine("An error occorred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
