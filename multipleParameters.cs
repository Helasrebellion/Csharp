/*
Multiple Parameters


You are writing a program to calculate the area of a rectangle. 
Currently it takes the the length and the height as inputs.
Complete the given method to take them as arguments, then calculate and return the area.

Sample Input
4
5

Sample Output
20
Use length*height formula to get the area of rectangle.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipleParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            
            
            //Output
            Console.WriteLine(Area(length,height));
        }
        //complete the method
        static int Area(int a, int b)
        {
            return a*b;
        }
    }
}
