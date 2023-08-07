using System;

namespace _10._07._2023.__21._57
{
    class Program
    {
        static void Main(string[] args)
        {
           // bool isZero = true;
            Console.WriteLine("enter an integer here: ");
            string inTeger = Console.ReadLine();
            if(inTeger[2] == '0' )
            {
                Console.WriteLine("the third bit of your input is zero");
            }
            else if(inTeger[2] == '1'){
            Console.WriteLine("The third bit of your input is one");
            }

                Console.WriteLine();

                Console.Write("Enter a four digits integer here: ");
                string dig = Console.ReadLine();
                int num = int.Parse(dig);
                int a = num %10;
                int b = (num / 10) % 10;
                int c = (num / 100) % 10;
                int d = (num / 1000) % 10;
                int digsum = a + b + c + d;
                Console.WriteLine(digsum);
                Console.WriteLine($"{dig[3]}{dig[2]}{dig[1]}{dig[0]}");
                Console.WriteLine($"{dig[3]}{dig[0]}{dig[1]}{dig[2]}");
                Console.WriteLine($"{dig[0]}{dig[2]}{dig[1]}{dig[3]}");

                Console.Write("Enter a number less than 100: ");
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
            //  bool isPrime = A[i] >=1;

            //  for( int prime = 2; prime < A[i]; prime++)
            //  {
            //     if(A[i] % prime == 0)
            //     {
            //         isPrime = false;
            //         break;
        }