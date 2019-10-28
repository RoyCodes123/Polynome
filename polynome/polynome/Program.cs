using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[] { -3, 2, 4.5, 8, -1, 0, 0, 0, -7, 6 };
            double[] arr1 = new double[] { 0, 2, 5, -6, -1, 0, 7, 0, 0, 1 };
            Polynome poly = new Polynome(arr);
            Polynome poly1 = new Polynome(arr1);
            Console.WriteLine(poly.ToString());
            Console.WriteLine(poly1.ToString());
            Console.WriteLine(poly.Add(poly1).ToString());
        }
    }
}
