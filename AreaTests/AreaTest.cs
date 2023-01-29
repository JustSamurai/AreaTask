using AreaTask;

namespace AreaTests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Circle()
        {
            Circle circle = new Circle("Circle", 12); // ������� ������
            double expected = 452.4; // ��������� ���������

            double result = circle.CalcSquare(); // ���������� ����������

            Assert.AreEqual(expected, result); // ���������
        }
    }

    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Triangle()
        {
            Triangle triangle = new Triangle("Triangle", 4, 4, 5); // ������� ������
            double expected = 7.8; // ��������� ���������

            double result = triangle.CalcSquare(); // ���������� ����������

            Assert.AreEqual(expected, result); // ���������
        }

        [TestMethod]
        public void isRectangle()
        {
            var triangle = new Triangle("Triangle", 2, 3, 4);// ������� ������

            var result = triangle.isRectangular(); // ���������� ����������

            Assert.IsFalse(result); //�������� ���������� ����������
        }
    }
}