using System;
using System.Collections.Generic;

namespace HW_4._1
{
    public class Triangle
    {
        public double first;
        public double second;
        public double third;
        public virtual double ReturnFirstEdge() { return first; }

        protected Triangle() { }
        public Triangle(double first_side, double second_side, double third_side)
        {
            if (ChangeSide(first_side, second_side, third_side))
            {
                first = first_side;
                second = second_side;
                third = third_side;
            }
            else
                throw new Exception(@"Помилка ініціалізації трикутника");
        }

        public bool ChangeSide(double first_side, double second_side, double third_side)
        {
            if (first_side > 0 && second_side > 0 && third_side > 0
                && first_side + second_side > third_side
                && second_side + third_side > first_side
                && first_side + third_side > second_side)
            {
                first = first_side;
                second = second_side;
                third = third_side;

                return true;
            }
            return false;
        }

        public double GetPerimeter() => first + second + third;

        public virtual List<string> CalculateAngles() => Angles;

        public virtual List<string> Angles =>
            new List<string>
            {
                getAngle(second, third, first),
                getAngle(first, third, second),
                getAngle(third, second, first)
            };

        private string getAngle(double a_side, double b_side, double c_side)
        {
            var angle = Math.Acos((a_side * a_side + b_side * b_side - c_side * c_side) / (2 * a_side * b_side * b_side));
            return $"{angle} radian";
        }

    }
    public class EquilateralTriangle : Triangle
    {
        public double Area;
        public double GetEdge => first;

        public double GetArea() => first * first * Math.Sqrt(3) / 2;
            
        public override List<string> CalculateAngles() => new List<string> { "60", "60", "60" };
    }
}
