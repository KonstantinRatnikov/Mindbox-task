using NUnit.Framework;
using ShapeLibrary;

namespace Тестирование_ShapeLibrary
{
    [TestFixture]
    public class ShapeTests
    {
        [Test]
        public void CircleAreaCalculation()
        {
            Circle circle = new Circle(10);
            Assert.AreEqual(314.16, Math.Round(ShapeCalculator.CalculateArea(circle), 2));
        }

        [Test]
        public void TriangleAreaCalculation()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, ShapeCalculator.CalculateArea(triangle));
        }

        [Test]
        public void RightAngledTriangleCheck()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightAngled);
        }
    }
}
