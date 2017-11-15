using System;

namespace _6._end7
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number,seven;
            Console.WriteLine("Введите число");
            Number=Convert.ToInt32 (Console.ReadLine ());
            if(Number%2==0){
                Console.WriteLine("Это четное число");
            } else
            {
                Console.WriteLine("Это нечетное число");
            }
            seven=Number%10;
            if (seven==7){
                Console.WriteLine("И оно заканчивается на 7");
            }else{
                Console.WriteLine("И оно не заканчивается на 7");
            }
        }
    }
}
