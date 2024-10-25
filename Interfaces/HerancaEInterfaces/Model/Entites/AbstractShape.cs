using HerancaEInterfaces.Model.Enums;

namespace HerancaEInterfaces.Model.Entites
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
