using System;

namespace New_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // int[][] jaggedArray = new int []
            // {
            // Console.WriteLine("Hello World!");
            //     new int[]{0,1,2,3},
            //     new int[]{4,5,6,7},
            //     new int[]{8,9,10,11},
            //     new int[]{12}, 
            //}    
            // write a program that creates two jagged arrays of integers.
            // perform addition and subtraction operations between corresponding elements of the arrays, 
            // storing the result in a new jagged array. 
            // Display the resulting jagged arrays

            int[][] jaggedArray1 = 
            {
             new int[] {1,2,3,4},
             new int[] {0,2,4,6},
             new int[] {1,3,5,7},
             new int[] {0,1,3,5},
            };

            int sub;
            int pos;
            int[][] jaggedArray2 = 
            {
              new int[] {5,6,7,8},
              new int[] {1,3,5,7},
              new int[] {2,4,6,8},
              new int[] {0,2,4,6},
            };
            
               for(int i = 0; i < jaggedArray1.Length; i++)
            {
                // for(int j = 0; j < jaggedArray1[i].Length; j++)
                // {
                //  // Console.Write(jaggedArray1[i][j] + jaggedArray2[i][j] + " ");
                // }  

                
                Console.Write(" ");
                
              
               for(int j = 0; j < jaggedArray1[i].Length; j++)
                {
                 sub = jaggedArray1[i][j] - jaggedArray2[i][j];
                 //pos = jaggedArray1[i][j] + jaggedArray2[i][j];
              
                  Console.Write(sub);
                }  

                Console.Write("\n");
                
               for(int j = 0; j < jaggedArray1[i].Length; j++)
                {
                 //sub = jaggedArray1[i][j] - jaggedArray2[i][j];
                 pos = jaggedArray1[i][j] + jaggedArray2[i][j];
              
                  Console.Write(pos);
                }  
             
                
                
             
           }
             
       }
    }

}
