using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.palindrom
{
    class Program
    {
        int Sym(uint a)
        {
            uint x, y;
            x = a;
            y = 0;
            while(x){
            y = y*10 + x%10;
            x /= 10;
            }
            return a == y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i=0;i<100;i++){
                if (Sym(i*i)){
                    Console.WriteLine(i);
                    }
            }
        }
    }
}

