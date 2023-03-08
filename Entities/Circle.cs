namespace Exercicio_POO_18_Classes_Metodos_Abstratos_Shape.Entities
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(ColorEnum color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area() => Math.PI * Math.Pow(Radius, 2);

    }
}
