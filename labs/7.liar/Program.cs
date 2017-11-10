using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.liar
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Выбери 2 ответ");
            input=Convert.ToInt32 (Console.ReadLine ()); 
            if (input==2){
                Console.WriteLine("Неправильно :DDD");
            }else
            {
                Console.WriteLine("Сказано же 2й ответ!");
            }
        }
    }
}
