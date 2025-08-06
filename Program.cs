using System.Numerics;

namespace Assignments_5._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // right diagonal is /
            int[,] matrix = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6}
            };

            int firstNum = matrix[0, matrix.GetLength(1) - 1];
            int lastNum = matrix[matrix.GetLength(0) - 1, 0];
            int sum = firstNum + lastNum;
            Console.WriteLine($"Addition of the right Diagonal element is: {sum}");
        }
    }
}
