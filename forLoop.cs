using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class forLoop
    {
        static void Main(string[] args)
        {
            /* 
            Anna's hummingbird, now believed to be the fastest bird in the world relative to its size, 
            can reach speeds of 80 km per hour.

            Task
            Write a program to output how many kilometers it will travel each hour over 5 hours of flight.

            Output
            80
            160
            240
            320
            400

            Hint
            Simply multiply 80 by a counter for each iteration.
            Use the for loop to perform the multiplications iteratively.
            */

            //Write your code here

            for (int i=1; i<= 5; i++)
            {
                Console.WriteLine(i *80);
            }
            
        }
    }
}
