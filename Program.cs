using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFermaThrm
{
    internal class Program
    {
        static double Func(double x)
        {
            // Реализация функции f(z)
            return x * x;
        }

        static double CalculateIntegral(double[] curvePoints)
        {
            double integral = 0;,

            for (int i = 0; i < curvePoints.Length - 1; i++)
            {
                // Вычисляем значение функции в текущей и следующей точках кривой
                double f1 = Func(curvePoints[i]);
                double f2 = Func(curvePoints[i + 1]);

                // Вычисляем значение прямоугольника (f(x) * h)
                double rectangle = f1 * (curvePoints[i + 1] - curvePoints[i]);

                // Добавляем значение прямоугольника к интегралу
                integral += rectangle;
            }

            return integral;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("кругом обман - доказательства Теоремы Ферма не будет, только Коши-Буяковского!" + " \n");
            double[] curvePoints = { 0, 0.5, 1 }; // Заданные точки кривой

            double integral = CalculateIntegral(curvePoints);

            Console.WriteLine("Значение интеграла: " + integral);
        }
    }
}
