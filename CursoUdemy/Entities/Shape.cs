using CursoUdemy.Entities.ENUMs;

namespace CursoUdemy.Entities.Enums;

abstract class Shape
{

    public Color Color { get; set; }

    protected Shape(Color color)
    {
        Color = color;
    }

    public abstract double Area();

}
