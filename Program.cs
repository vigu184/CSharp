using System;

namespace C2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.Write(i); //Prinitng 1
            for(;i<5;i++)
            {
                Console.Write("\n"+i);
                if(i>2)
                {
                    Console.Write(i);
                }
            }
        }
    }
}
