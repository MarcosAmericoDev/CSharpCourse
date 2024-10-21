namespace Directory_DirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:/temp/myfolder";

            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders) 
                {
                    Console.WriteLine(s);
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
