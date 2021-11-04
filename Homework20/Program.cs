using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework20
{
    /*Задачи
 В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
 -метод получает входным параметром переменную типа double;
 -метод возвращает значение типа double, которое является результатом вычисления.

 Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
 -длину окружности по формуле D = 2 * π* R;
 -площадь круга по формуле S = π* R²;
 -объем шара. Формула V = 4/3 * π * R³.
 Методы должны быть объявлены как статические.
 */
    class Program
    {

        static void Main(string[] args)
        {
            Func<double, double> func = GetСircumference;
            if (func != null)
            { double circumference = func(10); Console.WriteLine("Длина окружности равна {0:f2}", circumference); }
            func += GetSquare;
            if (func != null)
            { double square = func(20); Console.WriteLine("Площадь круга равна {0:f3}", square); }
            func += GetVolume;
            if (func != null)
            { double volume = func(1000); Console.WriteLine("Объем шара равен {0:f3}", volume); }
            Console.ReadKey();
        }
        static double GetСircumference(double Radius)
        {
            double circumference = Math.PI * 2 * Radius;
            return circumference;
        }
        static double GetSquare(double Radius)
        {
            double square = Math.PI * Math.Pow(Radius, 2.0);
            return square;
        }
        static double GetVolume(double Radius)
        {
            double volume = Math.PI * Math.Pow(Radius, 2.0) * 4 / 3;
            return volume;
        }
    }
}
