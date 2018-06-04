using System;

namespace fund1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // for(int i=1; i<=255; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // for (int i=1; i<=100; i++)
            // {
            //     if(i%3==0 && i%5==0)
            //     {
            //         continue;
            //     }
            //     else if(i % 3==0 || i%5==0)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }

            // for (int i=1; i<=100; i++)
            // {
            //     if(i%3==0 && i%5==0)
            //     {
            //         System.Console.WriteLine(i + " fizzbuzz!");
            //     }
            //     else if(i % 3==0)
            //     {
            //         Console.WriteLine(i + " fizz");
            //     }
            //     else if(i%5==0)
            //     {
            //         Console.WriteLine(i + " buzz");
            //     }
            // }

            Random randy = new Random();
            for (int i=1; i<=10; i++)
            {
                int check = randy.Next(1,100);
                if(check%15==0)
                {
                    System.Console.WriteLine(check + " fizzbuzz!");
                }
                else if(check % 3==0)
                {
                    Console.WriteLine(check + " fizz");
                }
                else if(check % 5==0)
                {
                    Console.WriteLine(check + " buzz");
                }
                else
                {
                    System.Console.WriteLine(check);
                }
            }
        }
    }
}
