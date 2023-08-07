using System;

namespace New_folder__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number here: ");
             int n = int.Parse(Console.ReadLine());
                int count = 0;
                for(int i= 1; i <=n; i++)
                {
                if(n %i == 0)
                {
                    count++;
                }
                }
                if(count == 2){
                    Console.WriteLine($"{n} is a prime number");
                }
                else{
                    Console.WriteLine($"{n} is not a prime number");
                }
        }
    }
}
