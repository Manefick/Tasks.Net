using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите цифру которая соотвествует названию фигуры площадь которой хотите найти\n" +
                "1-Square\n2-Circle\n3-Treangle");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.WriteLine("print side of square");
                    double SideSquare = double.Parse(Console.ReadLine());
                    Console.WriteLine("print name of shape ");
                    string NameShape = Console.ReadLine();
                    Square square = new Square(NameShape, SideSquare);
                    UserInterface.ShapeArea(square);
                    break;
                case 2:
                    Console.WriteLine("print radius of circle");
                    double RadiusCircle = double.Parse(Console.ReadLine());
                    Console.WriteLine("print name of shape ");
                    string CircleName = Console.ReadLine();
                    Circle circle = new Circle(CircleName, RadiusCircle);
                    UserInterface.ShapeArea(circle);
                    break;
                case 3:
                    Console.WriteLine("print side1 of Treangle");
                    double TreangleSide1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("print side2 of Treangle");
                    double TreangleSide2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("print side3 of Treangle");
                    double TreangleSide3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("print name of shape ");
                    string TreangleName = Console.ReadLine();
                    Triangle triangle = new Triangle(TreangleName, TreangleSide1, TreangleSide2, TreangleSide3);
                    UserInterface.ShapeArea(triangle);
                    break;
                default:
                    Console.WriteLine("You enter the wrong number please try again!!!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
