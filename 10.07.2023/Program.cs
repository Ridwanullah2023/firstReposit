using System;

namespace _10._07._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //HackerBank
            //LeetCode
          //  Console.WriteLine("Hello World!");
            int[] A = {117, 211,313,419, 515, 15485863};
          //  int Min = A[0];
            // for(int i=0; i<A.Length; i++)
            // {
            //   if(A[i] <=Min){
            //     Min = A[i];
            //   }
            // }
            // Console.WriteLine($"The least number is {Min}");

          // bool isPrime = true;
           for(int i=0; i< A.Length; i++)
           {

            bool isPrime = A[i] >=1;

             for( int prime = 2; prime < A[i]; prime++)
             {
                if(A[i] % prime == 0)
                {
                    isPrime = false;
                   break;
                }
            }
            if(isPrime){

              Console.WriteLine($"{A[i]}");
            }
           }
             
          
        }
    }
}