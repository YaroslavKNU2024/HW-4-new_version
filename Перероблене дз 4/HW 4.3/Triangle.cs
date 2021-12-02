using System;

namespace HW_4._3
{
    abstract class Triangle
    {
        public const double RightAngle = 90 * Math.PI / 180;
        public double a;
        public double b;
        public double alpha;

        public Triangle(double a, double b, double alpha)
        {
            this.a = a;
            this.b = b;
            this.alpha = alpha;
        }

        public virtual double Perimeter() => Math.Pow(a, 2) + Math.Pow(b, 2)- 2 * a * b * Math.Cos(alpha * Math.PI / 180);
        public virtual double Area() => a * b * Math.Sin(alpha * Math.PI / 180);
    }

    class RightTriangle: Triangle
    {
        public RightTriangle(double a, double b, double alpha): base(a, b, alpha) {}

        public override double Area()
        {
            return alpha == RightAngle
                ? a * b / 2
                : a * b * Math.Sin(alpha) / 2;
        }
        public override double Perimeter()
        {
            if (alpha == RightAngle)
                return a + b + Math.Sqrt(a * a + b * b);
            double hypothenuse = Math.Max(a, b);
            double xleg = hypothenuse * Math.Sin(alpha);
            return a + b + Math.Sqrt(a * a + b * b - 2 * Math.Cos(alpha));
        }
    }

    class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double a, double b, double alpha) : base(a, b, alpha)
        {
            this.a = a;
            this.b = b;
            this.alpha = alpha * Math.PI / 180;
        }
        public override double Perimeter()
        {
            double SmallerSide = Math.Min(a, b);
            double BiggerSide = Math.Max(a, b);
            if (alpha < RightAngle)
                SmallerSide = 2 * BiggerSide * Math.Sin(alpha / 2);
            return BiggerSide * 2 + SmallerSide;
        }

        public override double Area()
        {
            double height;
            double SmallerSide = Math.Min(a, b);
            double BiggerSide = Math.Max(a, b);
            if (alpha < RightAngle)
            {
                height = BiggerSide * Math.Cos(alpha / 2);
                SmallerSide = 2 * BiggerSide * Math.Sin(alpha / 2);
            } 
            else
                height = BiggerSide * Math.Sin(alpha / 2);
            return SmallerSide * height / 2;
        }

    }

    class Default : Triangle
    {
        public Default(double a, double b, double alpha) : base(a, b, alpha)
        {
            base.a = a;
            base.b = b;
            base.alpha = alpha;
        }

        public override double Area() => base.Area();

        public override double Perimeter() => base.Perimeter();

    }

}
