namespace ShapeLibrary
{
    public abstract class Shape
    {
        public abstract double Area { get; }
    }

    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area => Math.PI * Radius * Radius;
    }

    public class Triangle : Shape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public bool IsRightAngled
        {
            get
            {
                double a2 = SideA * SideA;
                double b2 = SideB * SideB;
                double c2 = SideC * SideC;

                return (a2 + b2 == c2) || (a2 + c2 == b2) || (b2 + c2 == a2);
            }
        }

        public override double Area
        {
            get
            {
                double s = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            }
        }
    }

    // Дополнительные фигуры могут быть добавлены аналогичным образом

    public class ShapeCalculator
    {
        public static double CalculateArea(Shape shape)
        {
            return shape.Area;
        }
    }
}