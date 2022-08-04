/*
Passing Arguments


Management has decided to increase the total salary budget.
The program you are given takes the current salary budget and the raise percentage as input. 
It should output the salary budget before the increase, then calculate and output the budget 
with the raises included.
Fix the program by completing the Increase() method (which should calculate the new salary budget) 
and calling it, so that the provided outputs work correctly.

Sample Input
150000
15

Sample Output
Before the increase: 150000
After the increase: 172500

Explanation
The first input (150000) represents the initial value of salary budget, 
the second one is the raise percentage - 15%. 
So, after the increase, the salary budget should be 1.15*150000 = 172500.
You should pass the salary budget argument by reference in order to change its value.
Don't forget to use ref keyword both in method definition and its call.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passingArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            int salaryBudget = Convert.ToInt32(Console.ReadLine());
            int percent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before the increase: " + salaryBudget);
            
            //complete the method call
            Increase(ref salaryBudget, percent);

            Console.WriteLine("After the increase: " + salaryBudget);
        }
        //complete the method
        static void Increase(ref int x, int y)
        {
            x = x*(y+100)/100;
        }
    }
}
