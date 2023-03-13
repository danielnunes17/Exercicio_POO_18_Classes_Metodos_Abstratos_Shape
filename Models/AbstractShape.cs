using Exercicio_POO_18_Classes_Metodos_Abstratos_Shape.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO_18_Classes_Metodos_Abstratos_Shape.Models
{
    public abstract class AbstractShape : IShape
    {
        public ColorEnum Color { get; set; }

        public abstract double Area();
    }
}
