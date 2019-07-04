using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedToRect.Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] d2 = { { 1, 2 , 3 }, { 4, 5, 6 } };
            Console.WriteLine("Rectangular arr: ");
            for (int i = 0; i < d2.GetLength(0); i++)
            {
                for (int j = 0; j < d2.GetLength(1); j++)
                    Console.Write("{0} ", d2[i, j]);
                Console.WriteLine();
            }
            double[][] dj = d2.toJagged();
            string arr = string.Join(",", dj.SelectMany(i => i));  // 1, 2, 3, 4, 5, 6
            string[] mass = arr.Split(',');
            Console.WriteLine("Jagged arr: ");
            for (int i = 0; i < dj.Length; i++)
            {
                for (int j = 0; j < dj[i].Length; j++)
                    Console.Write("{0} ", dj[i][j]);
                Console.WriteLine();
            }
            int[][] ij = { new[] { 1, 2 }, new[] { 3, 4, 5 }, new[] { 6, 7, 8, 9 } };
            Console.WriteLine("Jagged array: ");
            for (int i = 0; i < ij.Length; i++)
            {
                for (int j = 0; j < ij[i].Length; j++)
                    Console.Write("{0} ", ij[i][j]);
                Console.WriteLine();
            }
            int[,] i2 = ij.to2D();
            string arr1 = string.Join(",", i2.Cast<int>());  // 1, 2, 0, 0, 3, 4, 5, 0, 6, 7, 8, 9
            string[] mass1 = arr1.Split(',');
            Console.WriteLine("C O N V E R T I N G --------> \nRectangular array: ");
            for (int i = 0; i < i2.GetLength(0); i++)
            {
                for (int j = 0; j < i2.GetLength(1); j++)
                    Console.Write("{0} ", i2[i, j]);
                Console.WriteLine();
            }
        }
    }
}
