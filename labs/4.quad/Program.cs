using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*4.Ввести с клавиатуры два числа.Определить, что больше, сумма квадратов или квадрат суммы этих  чисел.
Ответ  вывести в виде сообщения. */
namespace _4.quad
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstN,secondN,sumQuad,quadSum;
            Console.WriteLine("Введите первое число ");
            firstN= Convert.ToDouble (Console.ReadLine ());
            Console.WriteLine("Введите второе число ");
            secondN= Convert.ToDouble (Console.ReadLine ());
            sumQuad=(firstN*firstN)+(secondN*secondN);
            quadSum=(firstN+secondN)*(firstN+secondN);
            Console.WriteLine("сумма квадратов "+ sumQuad);
            Console.WriteLine("квадрат суммы "+ quadSum);
            if(sumQuad==quadSum){
                Console.WriteLine("сумма квадратов равна квадратy суммы");
            }else {
                if(sumQuad>quadSum){
                    Console.WriteLine("сумма квадратов больше");
                } else {
                Console.WriteLine("квадрат суммы больше");
                }
            }
        }
    }
}
