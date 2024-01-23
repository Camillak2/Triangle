using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
         
                Console.WriteLine("Введите значения сторон треугольника:");
                Console.Write("Сторона A: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Сторона B: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Сторона C: ");
                double c = Convert.ToDouble(Console.ReadLine());

                double perimetr2 = (a + b + c) / 2;
                double square = Math.Sqrt(perimetr2 * (perimetr2 - a) * (perimetr2 - b) * (perimetr2 - c));
           

                if (a <= 0 || b <= 0 || c <= 0)
                {
                    Console.WriteLine("У треугольника все стороны должны быть положительными!");
                }
                else
                {
                    if (a + b < c || a + c < b || c + b < a)
                    {
                        Console.WriteLine("Такого треугольника не существует.");                        
                    }
                    else
                    {
                        if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) || Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2))
                        {
                            Console.WriteLine("Треугольник прямоугольный.");
                        }
                        else if (Math.Pow(a, 2) + Math.Pow(b, 2) < Math.Pow(c, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) < Math.Pow(b, 2) || Math.Pow(c, 2) + Math.Pow(b, 2) < Math.Pow(a, 2))
                        {
                            Console.WriteLine("Треугольник остроугольный.");
                        }
                        else
                        {
                            Console.WriteLine("Треугольник тупоугольный.");
                        }

                        Console.WriteLine("Площадь треугольника: " + square);
                    }
                }
                      
            Console.ReadKey();
        }
    }
}
