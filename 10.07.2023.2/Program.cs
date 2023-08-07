
using System;

namespace _10._07._2023._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] a = new int[4];
            int[] b = new int[4];
            for(int i = 0; i <4; i++)
            {
                Console.Write("enter your first array here: ");
                a[i] = int.Parse(Console.ReadLine());
                Console.Write("enter your second array here: ");
                b[i] = int.Parse(Console.ReadLine());
                sum+=a[i];
                sum += b[i];
            }
        // if(a[i] >= max)
        // {
        //     max = a[i];
        // }
        // }
        //  Console.WriteLine($"The highest number is {max}");
        //  Console.WriteLine();
        //  Console.WriteLine($"Table {max}");
        //  for(int i = 1; i<= 12; i++){
        //   Console.WriteLine($"{max} x {i} = {max * i}");
       

            Console.WriteLine(sum);
        }
    }
}

