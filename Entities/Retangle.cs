using Exercicio_POO_18_Classes_Metodos_Abstratos_Shape.Models;
using System.Globalization;

namespace Exercicio_POO_18_Classes_Metodos_Abstratos_Shape.Entities

{
    public class Retangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area() => Width * Height;

        public override string ToString() => "Retangle Color = "
                + Color
                + ", width = "
                + Width.ToString("F2", CultureInfo.InvariantCulture)
                + ", height = "
                + Height.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
    }
}
