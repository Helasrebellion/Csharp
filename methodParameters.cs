/*
Method Parameters


A store is running a promotion: if the total purchase price is equal to or exceeds
10000, the price will be discounted by 20%.
The program you are given takes the total purchase price as input.
Complete the given method to take the total purchase price as an argument, 
and calculate and return the discounted price if campaign's requirement is satisfied.
The method should return the same price if discount is not given.

Sample Input
13000

Sample Output
10400

Explanation
13000>10000, so the discount should be given: 13000-(0.2*13000) = 10400.

Hint
You need to use if else statements inside the method.
Don't forget to mention the value type for the method parameter before its name.
Notice that method returns a value, so you need to use 
Console.Write()/Console.WriteLine() to execute the output.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace methodParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPrice = Convert.ToInt32(Console.ReadLine());
            
            //call the method
            Console.Write(Discount(totalPrice)); 
            
        }
        //complete the method declaration
        static int Discount(int i)
        {
            //complete the method body
            if (i >= 10000)
            i = (int)(i*0.8f);
            return i;
            
        }
    }
}
