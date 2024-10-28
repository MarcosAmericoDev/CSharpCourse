using EstudoIComparable.Entites;

namespace EstudoIComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\in.txt";
            string outpath = @"c:\temp\out.txt";
            FileInfo fileInfo = new FileInfo(path);
            try
            {
                using(StreamReader sr = fileInfo.OpenText())
                {
                    List<Employee> list = new List<Employee>();

                    while(!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach(Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occorred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
