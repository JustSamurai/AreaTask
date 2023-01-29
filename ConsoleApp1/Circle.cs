using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTask
{
    public class Circle : ShapeFigure
    {
        public double Radius { get; private set; } // геттер, сеттер

        public Circle(string FigureName, double Radius) : base(FigureName) // конструктор с параметрами и передачей FigureName в базовый класс ShapeFigure
        {
            this.Radius = Radius; // передача значения
        }

        public override double CalcSquare() // переопределенный метод из класса-наследника 
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 1); // вычисляет площадь окружности и окргуляет до 1 знака после запятой. Возвращает результат
        }
    }
}
