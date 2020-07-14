using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson32
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxElement = int.MinValue;
            int[,] A = new int[10, 10];
            int[] maxElementIndex = new int[2];
            Random rand = new Random();
            Console.SetCursorPosition(0, 1);
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = rand.Next(0, 100);
                    if(maxElement<A[i,j])
                    {
                        maxElement = A[i, j];
                        maxElementIndex[0] = i;
                        maxElementIndex[1] = j;
                    }
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(maxElement);
            Console.SetCursorPosition(0, A.GetLength(0) + 2);
            A[maxElementIndex[0], maxElementIndex[1]] = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (i == maxElementIndex[0] && j == maxElementIndex[1])
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.CursorVisible = false;
        }
    }
}
