using System;

namespace _10.tween
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number;
            Console.WriteLine("Введите 3х значное число: ");
            Number=Convert.ToInt32 (Console.ReadLine ());
            if (((Number/100)==(Number%10)) && ((Number%10)==(Number/10%10))){
                Console.WriteLine("Числа одинаковые");
            }else {
                Console.WriteLine("Числа различаются");
            }
        }
    }
}
