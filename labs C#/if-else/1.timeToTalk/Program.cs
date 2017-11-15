using System;
namespace git_tutorial
{
  class Program
  {
    static void Main(string[] args)
    {
      int startHours,lengthOfTalk,minutePrice,dayOfWeek;
      double endValue;
      //Написать программу для определения стоимости  переговоров, если стоимость с 22  часов до 8 часов  на 20% ниже,
      // а в субботу и воскресенье дополнительно  предоставляется скидка 10% 
      Console.WriteLine("Введите время начала разговора от 0  до 24 часов");
      startHours = Convert.ToInt32 (Console.ReadLine ());
      Console.WriteLine("Введите продолжительность разговора в минутах");
      lengthOfTalk = Convert.ToInt32 (Console.ReadLine ());
      Console.WriteLine("Введите стоимость  минуты разговора");
      minutePrice = Convert.ToInt32 (Console.ReadLine ());
      Console.WriteLine("день недели от 1 до 7");
      dayOfWeek = Convert.ToInt32 (Console.ReadLine ());
      endValue=lengthOfTalk*minutePrice;
      if (((startHours>=22) && (startHours<=24))||((startHours>=0) && (startHours<=8))){
        endValue*= 0.8;
      }
      if ((dayOfWeek==6) || (dayOfWeek ==7)){
        endValue*=0.9;
      }
      Console.WriteLine("стоимость разговора равна "+endValue);
      Console.ReadKey();
    }
  }
}
