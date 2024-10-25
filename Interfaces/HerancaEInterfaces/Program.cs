using HerancaEInterfaces.Model.Entites;
using HerancaEInterfaces.Model.Enums;

namespace HerancaEInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IShape shape = new Circle() { Radius = 2.0, Color = Color.White };
            IShape shape2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };
            Console.WriteLine(shape);
            Console.WriteLine(shape2);
        }
    }
}
