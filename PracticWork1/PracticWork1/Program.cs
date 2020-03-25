using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticWork1
{
    class Program
    {
        public static void ExerciseOne()
        {
            Console.WriteLine("Введите высоту четырехугольной призмы, вписанной в цилиндр: ");
            float h = float.Parse(Console.ReadLine());
            float d = h / 2;
            double origS = (d * d) / 2;
            float a = (float) Math.Sqrt(origS);
            float v = (float) origS * h;
            float sideS = a * h;
            double surfaceS = 2 * origS + 4 * sideS;
            Console.WriteLine("Объем призмы равен: " + v);
            Console.WriteLine("Площадь полной поверхности равна: " + surfaceS);
            Console.ReadKey(true);
        }

        public static void ExerciseTwo()
        {
            double max, mid, min;
            Console.WriteLine("Введите значение А: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение В: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение С: ");
            double c = double.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    if (b > c)
                    {
                        max = a;
                        mid = b;
                        min = c;
                    }
                    else
                    {
                        max = a;
                        mid = c;
                        min = b;
                    }
                }
                else
                {
                    max = c;
                    mid = a;
                    min = b;
                }
            }
            else
            {
                if (b > c)
                {
                    if (a > c)
                    {
                        max = b;
                        mid = a;
                        min = c;
                    }
                    else
                    {
                        max = b;
                        mid = c;
                        min = a;
                    }
                }
                else
                {
                    max = c;
                    mid = b;
                    min = a;
                }
            }
            Console.WriteLine("Наибольшее число = " + max + " Среднее число = " + mid + " Наименьшее число = " + min);
            if (2 * (max - min) == 2 * mid)
            {
                Console.Write("Удвоенная разность наибольшего и наименьшего чисел равно удвоенному среднему числу.\n");
                Console.Write("2 * (" + max + " - " + min + ") = 2 * " + mid + "\n");
                Console.Write(2 * (max - min) + " = " + 2 * mid + "\n");
            }
            else
            {
                if (2 * (max - min) > 2 * mid)
                {
                    Console.Write("Удвоенная разность наибольшего и наименьшего чисел больше удвоенного среднего числа.\n");
                    Console.Write("2 * (" + max + " - " + min + ") > 2 * " + mid + "\n");
                    Console.Write(2 * (max - min) + " > " + 2 * mid + "\n");
                }
                else
                {
                    Console.Write("Удвоенная разность наибольшего и наименьшего чисел меньше удвоенного среднего числа.\n");
                    Console.Write("2 * (" + max + " - " + min + ") < 2 * " + mid + "\n");
                    Console.Write(2 * (max - min) + " < " + 2 * mid + "\n");
                }
            }
            Console.ReadKey(true);
        }

        public static void ExerciseThree()
        {
            Console.WriteLine("Введите начальное значение x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите конечное значение E: ");
            double e = double.Parse(Console.ReadLine());
            double p = 1;
            int i = 1;
            double u = x;
            double d = x + 1;
            double s = u / d;
            while (s >= e)
            {
                p = p * s;
                u = u + i;
                d = d + 5;
                s = u / d;
                if (i == 1)
                {
                    i = 2;
                }
                else
                {
                    i = 1;
                }
            }
            Console.WriteLine("Итоговое произведение = " + p + "\nПоследние член последовательности = " + s);
            Console.ReadKey(true);
        }
        static void Main() {
            Console.WriteLine("Введите номер задания: ");
            int k = int.Parse(Console.ReadLine());

            switch (k) {
                case 1:
                    ExerciseOne();
                    break;
                case 2:
                    ExerciseTwo();
                    break;
                case 3:
                    ExerciseThree();
                    break;
                default:
                    Console.WriteLine("Неизвестный номер задания.");
                    Console.ReadKey(true);
                    break;
            }
            
        }
    }
}
