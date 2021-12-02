using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4._2
{
    abstract class Shape
    {
        public virtual double Area() => 0;
        public virtual double Perimeter() => 0;

    }

    class Triangle: Shape
    {
        public double first, second, third;
        public Triangle(double first, double second, double third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public override double Perimeter() => first + second + third;
        public override double Area()
        {
            double p = (first + second + third) / 2;
            double area = Math.Sqrt(p * (p - first) * (p - second) * (p - third));
            return area;
        }
    }

    class Square: Shape
    {
        public Square (double side)
        {
            this.side = side;
        }
        public double side;
        public override double Perimeter() => side * 4;
        public override double Area() => side * side;
    }

    class Rectangle: Shape
    {
        public double first, second;
        public Rectangle(double first, double second)
        {
            this.first = first;
            this.second = second;
        }
        public override double Perimeter() => (first + second) * 2;
        public override double Area() => first * second;
    }

    class Circle: Shape
    {
        const double PI = 3.1415279;
        public double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Perimeter() => 2 * radius * PI;
        public override double Area() => PI * radius * radius;
    }

    class Rhombus: Shape
    {
        public double side, SmallDiagonal, BigDiagonal;
        public Rhombus(double side, double SmallDiagonal, double BigDiagonal)
        {
            this.side = side;
            this.SmallDiagonal = SmallDiagonal;
            this.BigDiagonal = BigDiagonal;

        }
        public override double Perimeter() => side * 4;
        public override double Area() => SmallDiagonal * BigDiagonal / 4;

    }

}
