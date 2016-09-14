using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

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

            Console.WriteLine(maxPerSize);

            //for (var i = 0; i < n; ++i)
            //{
            //    for (var j = 0; j < n; ++j)
            //    {
            //        Console.Write(grid[i][j]);
            //    }
            //    Console.WriteLine();
            //}
        }

        //static int maxCircleSizePerGridSize(int n)
        //{
        //    return (n%2 != 0)
        //}
    }
}
