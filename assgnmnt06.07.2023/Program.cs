using System;

namespace assgnmnt06._07._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("what is your array length?");
            int n = int.Parse(Console.ReadLine());
            int[] arrList = new int[n];
            int Max = arrList[0];
            int Min = arrList[0];
            for(int i= 0; i<n; i++)
            {
            Console.Write("Enter your array list:");
            arrList[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Your list:");
            for(int i = 0; i<arrList.Length; i++)
            {
            Console.WriteLine(arrList[i]);
            if(arrList[i] > Max)
            {
                Max = arrList[i];
            }
            if(arrList[i] < Min)
            {
                Min = arrList[i];
            }
            }
            Console.WriteLine($"The maximum number in the array is {Max}");
            Console.WriteLine($"The minimum number in the array is {Min}");


             Console.Write("what is your array length?");
            int size = int.Parse(Console.ReadLine());
            int[] List = new int[size];
             for(int i= 0; i<size; i++)
            {
            Console.Write("Enter your array list:");
            List[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Your list in a reversed order is:");
            for(int i = size-1; i>=0; i--)
            {
            Console.WriteLine(List[i]);
            }
        }
    }
}
