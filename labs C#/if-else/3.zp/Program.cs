using System;

namespace _3.zp
{
    class Program
    {
        static void Main(string[] args)
        {
            double experience=1.0,salary;
            Console.WriteLine("Введите ваш стаж ");
            experience= Convert.ToDouble (Console.ReadLine ());
            Console.WriteLine("Введите вашу зарплату ");
            salary= Convert.ToDouble (Console.ReadLine ());
            if ((experience>= 5) && (experience <= 9)){
                experience=1.02;
                salary*=experience;
            }
            if ((experience>=10) && (experience<=20)){
                experience=1.1;
                salary*=experience;
            }
            Console.WriteLine("Ваша Зарплата, с учетом стажа, составляет "+ salary);
        }
    }
}
