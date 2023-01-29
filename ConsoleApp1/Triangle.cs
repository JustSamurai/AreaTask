using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTask
{
    public class Triangle : ShapeFigure
    {
        public double ab { get; private set; } // геттер, сеттер
        public double bc { get; private set; } // геттер, сеттер
        public double ac { get; private set; } // геттер, сеттер

        public Triangle(string FigureName, double ab, double bc, double ac) : base(FigureName) // конструктор с параметрами и передачей FigureName в базовый класс ShapeFigure
        {
            if (ab < 0 || bc < 0 || ac < 0) throw new ArgumentException($"Error: Side can not be less than 0\nCheck your input values"); // Исключение: треугольника с такими сторонами не существует
            else if (ab > (bc + ac) || bc > (ab + ac) || ac > (ab + bc)) throw new ArgumentException($"Error: Your side greater than summary of two another sides\nCheck your input values"); // одна сторона больше, чем сумма других двух сторон
            else // передача значений
            { 
                this.ab = ab;
                this.bc = bc;
                this.ac = ac;
            }
        }
        public override double CalcSquare() // переопределенный метод из класса-наследника 
        {
            double p = (ab + bc + ac) / 2; // вычисляет полупериметр
            double area = Math.Round(Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac)), 1); // вычисляет площадь через формулу Герона, округляя до одного знака после запятой
            return area; // возвращает значение
        }
        public bool isRectangular() // проверка, что треугольник является прямоугольным
        {
            bool check = (ab == Math.Sqrt(Math.Pow(bc, 2) + Math.Pow(ac, 2)) 
                         || bc == Math.Sqrt(Math.Pow(ab, 2) + Math.Pow(ac, 2))
                         || ac == Math.Sqrt(Math.Pow(ab, 2) + Math.Pow(bc, 2)));
            return check; // возвращает значение
        }
    }
}
