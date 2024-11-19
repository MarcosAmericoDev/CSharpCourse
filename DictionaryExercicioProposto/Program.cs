namespace DictionaryExercicioProposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string source = Console.ReadLine();
            SortedDictionary<string, int> election = new SortedDictionary<string, int>();

            try
            {
                using (StreamReader sr = new StreamReader(source))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int numberOfVotes = int.Parse(line[1]);
                        if (election.ContainsKey(name))
                        {
                            election[name] += numberOfVotes;
                            continue;
                        }
                        election[name] = numberOfVotes;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (KeyValuePair<string, int> pair in election)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
