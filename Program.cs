using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lighthouse
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            //string[] x_temp = Console.ReadLine().Split(' ');

            char[][] grid = new char[n][];
            for (var i = 0; i < n; ++i)
            {
                grid[i] = Console.ReadLine().ToCharArray();
            }

            var maxPerSize = (n - 1)/2;

            // n=1, n=2
            if (maxPerSize == 0)
            {
                Console.WriteLine(0);
                return;
            }

            // n>=3
            for (var i = 0; i < n; ++i)
            {
                for (var j = 0; j < n; ++j)
                {
                    // this is not the place we can build
                    if(grid[i][j] !='.') continue;


                }
            }

            //var point = new Point(1, 1);

                    //Console.WriteLine(maxPerSize);

                    //for (var i = 0; i < n; ++i)
                    //{
                    //    for (var j = 0; j < n; ++j)
                    //    {
                    //        Console.Write(grid[i][j]);
                    //    }
                    //    Console.WriteLine();
                    //}
            }

        static List<Point> findMiddle(int n)
        {
            var listOfPoints = new List<Point>();
            if (n%2 == 0)
            {
                
            }
        }
    }
}
