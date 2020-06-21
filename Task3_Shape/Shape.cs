using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Shape
{
    public abstract class Shape
    {
        public string Name { get; set; } = "Shape";

        public Shape(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name do not be null");
            }
            Name = name;
        }
        public override string ToString()
        {
            return $"Площадь {Name} = {Area()}";
        }
        public virtual double Area()
        {
            return 0.0;
        }
    }

    public class Square : Shape
    {
        public double Side { get; set; }

        public Square(string name, double side) : base(name)
        {
            Side = side;
        }
        public override double Area()
        {
            return Side * Side;
        }
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
    public class Triangle : Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        private double Perimeter { get { return (Side1 + Side2 + Side3) / 2; } }

        public Triangle(string name, double side1, double side2, double side3) : base(name)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }
        public override double Area()
        {
            return Math.Sqrt(Perimeter * (Perimeter - Side1) * (Perimeter - Side2) * (Perimeter - Side3));
        }
    }
}
