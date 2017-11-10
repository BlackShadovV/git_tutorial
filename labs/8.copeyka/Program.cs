using System;

namespace _8.copeyka
{
    class Program
    {
        static void Main(string[] args)
        {
            int value,number;
            Console.WriteLine("ввести цисло 1-99");
            number=Convert.ToInt32 (Console.ReadLine ()); 
            if (number >=10 && number <=20){
                 Console.WriteLine(" копеек");
            } else
            {
            value=number%10;
            if (value==1){
                 Console.WriteLine(" копейка");
            }
            if (value>=2 && value<=4) {
                 Console.WriteLine(" копейки");
            }
            if((value>=5 && value<=9) || value<0){
                Console.WriteLine(" копеек");
            }
        }}
    }
}
