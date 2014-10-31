using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //do
            //{
            //    Console.WriteLine(input);

            //    input = Console.ReadLine();
            //} while (input != "q");

            for (int i = 1; i < 8; i++)
            {
                for (int j = 1; j < 8; j++)
                {
                    if (i >= j) 
                    {
                        Console.Write(j);
                    }
                    else Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            //string[] names = { "Jeremiah", "Cassandra", "Zxander", "Devin", "Ryden" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.ReadLine();

        }
    }
}
