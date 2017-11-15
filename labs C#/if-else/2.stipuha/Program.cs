using System;
/*2.Написать программу для проверки  условия, если физика , 
математика и информатика сданы на 4или  5, то студент получит 
стипендию (то выражение «истина»). */
namespace _2.stipuha
{
    class Program
    {
        static void Main(string[] args)
        {
            int physics,math,inform;
            Console.WriteLine("Оценка по физике");
             physics = Convert.ToInt32 (Console.ReadLine ());
             Console.WriteLine("Оценка по математике");
             math = Convert.ToInt32 (Console.ReadLine ());
             Console.WriteLine("Оценка по информатике");
             inform = Convert.ToInt32 (Console.ReadLine ());
             if((physics<4) || (math<4) || (inform<4)){
                 Console.WriteLine("false");
             }else{
             Console.WriteLine("true");
             }
        }
    }
}
