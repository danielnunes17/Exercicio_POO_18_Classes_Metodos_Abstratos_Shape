using Exercicio_POO_18_Classes_Metodos_Abstratos_Shape.Entities;
using Exercicio_POO_18_Classes_Metodos_Abstratos_Shape.Entities.Enums;
using Exercicio_POO_18_Classes_Metodos_Abstratos_Shape.Models;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        IShape s1 = new Circle { Radius = 2.0, Color = ColorEnum.Red };
        IShape s2 = new Retangle { Width = 3.5, Height = 4.2, Color = ColorEnum.Blue };

        Console.WriteLine(s1);
        Console.WriteLine(s2);
    }
}

