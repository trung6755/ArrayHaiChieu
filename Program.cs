using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHaiChieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arrays = new int[3, 3];
            Console.WriteLine("Enter " + arrays.GetLength(0) + " rows and " + arrays.GetLength(1) + " columns: ");
            for (int i = 0; i < arrays.GetLength(0); i++)
            {
                for (int j = 0; j < arrays.GetLength(1); j++)
                {
                    arrays[i,j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < arrays.GetLength(0); i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < arrays.GetLength(1); j++)
                {
                    Console.Write(arrays[i, j] + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            int max = 0;
            int currentRow = 0;
            int currentColumn = 0;

            for (int i = 0;i < arrays.GetLength(0); i++)
            {
                for(int j = 0;j < arrays.GetLength(1); j++)
                {
                    
                    if(max < arrays[i, j])
                    {
                        max = arrays[i, j];
                        currentRow = i;
                        currentColumn = j;                       
                    }
                }
                break;
            }

            Console.WriteLine("GTLN cua ma tran la " + max + " o vi tri [" + currentRow + ", " + currentColumn + "]");

            Console.WriteLine();




            Console.ReadKey();
        }
    }
}
