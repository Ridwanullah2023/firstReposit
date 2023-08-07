using System;

namespace _06._07._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            
            //   for(int i= 1; i <= 12; i++)
            //   {
            //     for(int j=1; j <= 12; j++)
            //     {
            //         Console.WriteLine(i*j);
            //     }
            //   }

            //   Console.WriteLine("enter a number here: ");
            //   int first = int.Parse(Console.ReadLine());
            //   int count = 0;
            //   for(int i =1; i <= first; first--){
            //     count++;
            //     if(first %2 == 0){
            //     Console.WriteLine($"your {count} number is even");
            //     Console.WriteLine(first/2);
            //     }
            //     else{
            //         Console.WriteLine($"your {count} number is odd");
            //         Console.WriteLine(first*2);
            //     }
            //   }


            //   string[] name = new string[6]{"ab","ax","az","av","an","am"};
            //   for(int i=0; i< name.Length; i++){
            //     Console.WriteLine(name[i]);
            //   }
            // Console.WriteLine("How many names do you wish to enter?");
            // int n = int.Parse(Console.ReadLine());
            // string[] newList = new string[n];
            // for(int i=0; i<newList.Length; i++){
            //     Console.Write("enter a student's name here: ");
            //     newList[i] = Console.ReadLine();
            // }
            // Console.WriteLine("The names you entered are :");
            // for(int i= 0; i<newList.Length; i++){
            //     Console.WriteLine(newList[i]);
            // }
            // Console.Write("How many numbers do you want to enter?");
            // int n = int.Parse(Console.ReadLine());
            // int countEven = 0;
            // int countOdd = 0;
            // int[] yourList = new int[n];
            // for(int i=0; i<n; i++){
            //     Console.Write("enter a number here: ");
            //     yourList[i] = int.Parse(Console.ReadLine());
            //     if(yourList[i] %2 == 0){
            //         countEven++;
            //     }
            //     else{
            //         countOdd++;
            //     }
            // }
            // Console.WriteLine($"the odd numbers are {countOdd}");
            // Console.WriteLine($"the even numbers are {countEven}");

             Console.Write("How many numbers do you want to enter?");
            int n = int.Parse(Console.ReadLine());
            int countEven = 0;
            int countOdd = 0;
            int countPrime = 0;
            int[] yourList = new int[n];
            double sqrt = (double)Math.Sqrt(yourList);
            for(int i=0; i<n; i++){
                Console.Write("enter a number here: ");
                yourList[i] = int.Parse(Console.ReadLine());

                 if(yourList[i] %2 == 0){
                    countEven++;
                }
                else
                {
                    countOdd++;
                    if(yourList[i] %sqrt == 0){
                        Console.WriteLine("not a prime number");
                    }
                    else{
                        Console.WriteLine("it is a prime number");
                        countPrime++;
                    }
                }
                }
            Console.WriteLine($"the odd numbers are {countOdd}");
            Console.WriteLine($"the even numbers are {countEven}");
            Console.WriteLine($"the prime numbers are {countPrime}");
            
             
        }
    }
}
