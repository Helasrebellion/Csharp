using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cirleAreaFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            float radius = float.Parse(Console.ReadLine());
            double circleArea = pi*radius*radius;
            
            Console.WriteLine(Math.Round(circleArea,4));


        }
    }
}
