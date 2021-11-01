using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициенты k и b уравнения 0=kx+b");
            double k = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            if (k!=0)
            {
                double x;
                LinUr linUr = new LinUr(k, b);
                linUr.Root(k, b, out x);
                Console.WriteLine("x= {0:F2}", x);
            }
            
            else
            {
                Console.WriteLine("Ошибка! Деление на 0");
            }
            Console.ReadKey();
        }

        struct LinUr
        {
            double k { get; set; }
            double b { get; set; }

            public LinUr(double k, double b)
            {
                this.k = k;
                this.b = b;
            }

            public void Root(double k, double b, out double x)
            {
                x = -b / k;
                //Console.WriteLine("x= {0:F2}", x);
            }

        }

    }
}
