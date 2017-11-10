using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.coord
{
    class Program
    {
        static void Main(string[] args)
        {
            double x0,y0,x1,y1,distanceA,distanceB;
            Console.WriteLine("Введите координаты точки А");
            Console.WriteLine("Х=");
            x0=Convert.ToDouble (Console.ReadLine ());
            Console.WriteLine("У=");
            y0=Convert.ToDouble (Console.ReadLine ());
            Console.WriteLine("Введите координаты точки B");
            Console.WriteLine("Х=");
            x1=Convert.ToDouble (Console.ReadLine ());
            Console.WriteLine("У=");
            y1=Convert.ToDouble (Console.ReadLine ());
            distanceA=Math.Sqrt((x0*x0)+(y0*y0));
            distanceB=Math.Sqrt((x1*x1)+(y1*y1));
            Console.WriteLine(distanceA);
             Console.WriteLine(distanceB);
            if (distanceA==distanceB){
                Console.WriteLine("точки равноудаленны от начала координат");
            } else{
                if(distanceA<distanceB){
                    Console.WriteLine("Точка А ближе к началу координат");
                }else{
                     Console.WriteLine("Точка В ближе к началу координат");
                }
            }
        }
    }
}
