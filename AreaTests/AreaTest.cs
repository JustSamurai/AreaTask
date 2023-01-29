using AreaTask;

namespace AreaTests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Circle()
        {
            Circle circle = new Circle("Circle", 12); // входные данные
            double expected = 452.4; // ожидаемый результат

            double result = circle.CalcSquare(); // выполнение вычислений

            Assert.AreEqual(expected, result); // сравнение
        }
    }

    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Triangle()
        {
            Triangle triangle = new Triangle("Triangle", 4, 4, 5); // входные данные
            double expected = 7.8; // ожидаемый результат

            double result = triangle.CalcSquare(); // выполнение вычислений

            Assert.AreEqual(expected, result); // сравнение
        }

        [TestMethod]
        public void isRectangle()
        {
            var triangle = new Triangle("Triangle", 2, 3, 4);// входные данные

            var result = triangle.isRectangular(); // выполнение вычислений

            Assert.IsFalse(result); //проверка ожидаемого результата
        }
    }
}