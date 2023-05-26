using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayFind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 1, 5, 10, 15, 9, 7, 8, 4 };

            Console.WriteLine("Nhap tong: ");

            int tong = int.Parse(Console.ReadLine());

            ArrayList visited = new ArrayList();

            for(int i = 0; i< x.Length; i++)
            {
                if (visited.Contains(tong - x[i]))
                {
                    Console.WriteLine($"{x[i]} + {visited[visited.IndexOf(tong - x[i])]} = {tong}");
                }
                else
                {
                    visited.Add(x[i]);
                }

            }
            Console.ReadLine();


        }
    }
}
