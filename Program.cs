using Exercicio_POO_18_Classes_Metodos_Abstratos_Shape.Entities;
using System.Globalization;

internal class Program
{
    public static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Console.Write("Enter the number of shapes: ");
        int numberShapes = int.Parse(Console.ReadLine());
        for (int i = 1; i <= numberShapes; i++)
        {
            Console.WriteLine($"Shape #{i} data: ");
            Console.Write("Rectangle or Circle (r/c)? ");
            char shapeType = char.Parse(Console.ReadLine());
            if (shapeType == 'r')
            {
                shapes.Add(CreatRetangle());
            }
            else
            {
                shapes.Add(CreatCircle());
            }
        }
        Console.WriteLine();
        Console.WriteLine("SHAPE AREAS: ");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
    private static Retangle CreatRetangle()
    {
        Console.Write("Color (Black/Blue/Red): ");
        ColorEnum color = Enum.Parse<ColorEnum>(Console.ReadLine());
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        return new Retangle(width, height, color);
    }

    private static Circle CreatCircle()
    {
        Console.Write("Color (Black/Blue/Red): ");
        ColorEnum color = Enum.Parse<ColorEnum>(Console.ReadLine());
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        return new Circle(color, radius);
    }
}