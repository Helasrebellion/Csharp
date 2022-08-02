/* 
Multiple of 3


You are an elementary school teacher and explaining multiplication to students.
You are going to use multiplication by 3 as your example.
The program you are given takes N number as input. 
Write a program to output all numbers from 1 to N, replacing all numbers that are multiples of 3 by "*".

Sample Input
7

Sample Output
12*45*7
The N number is a multiple of 3 if N%3==0.
*/
using System;
using System.Collections.Generic;


namespace multipleOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int x = 1;
            
            while(x<=N){
            
                if (x%3 == 0){
                   Console.Write("*");
                }
                
                else{
                Console.Write(x);
                }
                x++;
            }
        }
    }
}
