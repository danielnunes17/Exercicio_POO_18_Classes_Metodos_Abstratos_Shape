namespace Exercicio_POO_18_Classes_Metodos_Abstratos_Shape.Entities
{
    public abstract class Shape
    {
        public ColorEnum Color { get; set; }

        public Shape(ColorEnum color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
