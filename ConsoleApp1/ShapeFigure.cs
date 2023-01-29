using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTask
{
    public abstract class ShapeFigure
    {
        public string FigureName { get; set; } // геттер, сеттер
        public ShapeFigure(string name) // конструктор абстрактного класса
        {
            this.FigureName = name; // установка значения
        }
        public abstract double CalcSquare(); // абстрактный метод
    }
    public static class ShapePrototype //  статический класс
    {
        public static double CalcSquare(ShapeFigure shapeFigure) => shapeFigure.CalcSquare(); // метод CalcSqure использует параметры метода из класса ShapeFigure
    }

}
