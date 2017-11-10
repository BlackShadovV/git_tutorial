using System;

namespace _9.days
{
    class Program
    {
        static void Main(string[] args)
        {
            int day,value;
            Console.WriteLine("введите число от 1 до 365");
            day=Convert.ToInt32 (Console.ReadLine ());
            value=day%7;
            if (value==1){
                Console.WriteLine("Понедельник");
            }
            if (value==2){
                Console.WriteLine("Вторник");
            }
            if (value==3){
                Console.WriteLine("Среда");
            }
            if (value==4){
                Console.WriteLine("Четверг");
            }
            if (value==5){
                Console.WriteLine("Пятница");
            }
            if (value==6){
                Console.WriteLine("Суббота");
            }
            if (value==7){
                Console.WriteLine("Воскресенье");
            }
        }
    }
}
