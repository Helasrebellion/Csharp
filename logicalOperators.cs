/* 
Logical Operators


Students should have at least 95% attendance and an average score of 80 to win a scholarship.
Write a program to take attendance and average score values as input and output "Accepted", if the given requirements are satisfied, and "Denied", if they are not.

Sample Input:
98
70

Sample Output:
Denied
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class logicalOperators
    {
        static void Main(string[] args)
        {
            int attendance = Convert.ToInt32(Console.ReadLine());
            int avgScore = Convert.ToInt32(Console.ReadLine());

            //your code goes here
            if (attendance >= 95 && avgScore >= 80)
            {
                    Console.WriteLine("Accepted");
            }
            else 
            Console.WriteLine("Denied");
            
        }
    }
}
