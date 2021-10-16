using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            int soma = 0;

            Console.WriteLine("---- Retangular multidimensional array ----");
            Console.WriteLine();
            int[,] myMatrix;
            myMatrix = new int[8, 5];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    myMatrix[i, j] = rnd.Next(1, 4512);
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(myMatrix[i, j] + "\t");
                    if (i == j)
                        soma += myMatrix[i, j];
                }
                
                Console.WriteLine();
            }
            Console.WriteLine("\n Soma da diogonal=" + soma);
            Console.ReadLine();
        }
    }
}
