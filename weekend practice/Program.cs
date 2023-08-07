using System;

namespace weekend_practice
{
    class Program
    {
        static void Main(string[] args)
        {
                //  int i = 0;
            // string Greetings = "Hello,Earth,and,Other,Planets!";
            // string [] greetingsArray = Greetings.Split(',');
            // for(i=0; i<greetingsArray.Length; i++)
            // Console.WriteLine(greetingsArray[i]);
            //string[] Colors = {"red","blue","green","yellow"};
            // do
            // {
            //     Console.WriteLine(Colors[i]);
            //     i++;
            // } while (i <= 3);


            // for(int i=1; i<=1000; i++)
            // {
            //     Console.WriteLine();
            //     Console.WriteLine($"Table {i}");
            //     for(int j=1; j<= 12; j++)
            //     {
            //         Console.WriteLine($"{i} x {j} = {i*j}");
            //     }
            // }


            Console.WriteLine("enter a positive integer here: ");
            int inT = int.Parse(Console.ReadLine());
            for(int i= 2; i <= inT; i++)
            {
                                        
                if(i %2 != 0)
                {
                  for(int j = 1; j<= i; j++)
                  {
                    if(inT % j == 0)
                    {
                        System.Console.WriteLine($"{j} is prime ");
                    }
                  }
                }
                // Console.WriteLine($"The prime numbers between 1 and your input are {inT}");
            }
        }

        
        
    }
}
