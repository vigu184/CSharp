using System;

namespace C2
{
    class Program
    {
        static void Main(string[] args) //init
        {
            int i = 1;
            Console.Write(i); //Prinitng 1
            for(;i<5;i++)
            {
                Console.Write("Sab Hile Hue Hai Ji \n"+i);
                //Truth Triumphs
                if(i>2)
                {
                    Console.Write(i);
                }
            }
        }
    }
}
