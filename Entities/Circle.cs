using Exercicio_POO_18_Classes_Metodos_Abstratos_Shape.Models;
using System.Globalization;

namespace Exercicio_POO_18_Classes_Metodos_Abstratos_Shape.Entities
{
    public class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area() => Math.PI * Math.Pow(Radius, 2);

        public override string ToString() => "Circle color = "
                + Color
                + ", radius = "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
    }
}
