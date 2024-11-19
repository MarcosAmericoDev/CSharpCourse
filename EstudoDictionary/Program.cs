namespace EstudoDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "997123123";
            cookies["phone"] = "921387135"; // está sobrescrevendo o valor anterior

            Console.WriteLine(cookies["phone"]);
            Console.WriteLine(cookies["email"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email")) 
            {
                Console.WriteLine(cookies["email"]);
            } else
            {
                Console.WriteLine("There's no 'email' key");
            }

            Console.WriteLine("Size: " + cookies.Count);
            Console.WriteLine("ALL COOKIES: ");

            foreach (var item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
