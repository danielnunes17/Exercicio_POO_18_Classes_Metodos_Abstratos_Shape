using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO_18_Classes_Metodos_Abstratos_Shape.Entities
{
    public class Retangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Retangle(double width, double height, ColorEnum color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area() => Width * Height;

    }
}
