using System;

namespace CodeWars_Tasks.SortableShapes
{
    public class Shape : IComparable<Shape>
    {
        public double Area { get; set; }

        public int CompareTo(Shape o)
        {
            return Area.CompareTo(o.Area);
        }
    }

    public class Square : Shape
    {
        public Square(double side)
        {
            Area = side * side;
        }
    }

    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            Area = width * height;
        }
    }

    public class Triangle : Shape
    {
        public Triangle(double basis, double height)
        {
            Area = basis * height / 2;
        }
    }

    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Area = radius * radius * Math.PI;
        }
    }

    public class CustomShape : Shape
    {
        public CustomShape(double area)
        {
            Area = area;
        }
    }
}
