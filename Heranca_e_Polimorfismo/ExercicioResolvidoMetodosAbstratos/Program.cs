using ExercicioResolvidoMetodosAbstratos.Entities;
using ExercicioResolvidoMetodosAbstratos.Entities.Enums;
using System.Globalization;

namespace ExercicioResolvidoMetodosAbstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> listOfShapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write($"Rectangle or Circle (r/c)? ");
                char typeOfShape = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color colorOfShape = Enum.Parse<Color>(Console.ReadLine());
                if (typeOfShape == 'r')
                {
                    Console.Write("Width: ");
                    double widthOfShape = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double heightOfShape = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listOfShapes.Add(new Rectangle(widthOfShape, heightOfShape, colorOfShape));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radiusOfShape = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listOfShapes.Add(new Circle(radiusOfShape, colorOfShape));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");

            foreach(Shape shape in listOfShapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
