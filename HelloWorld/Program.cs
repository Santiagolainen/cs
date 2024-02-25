using System;
using System.Linq;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            int[,] nums = { {1, 3, 5 },
                            {2, 4, 6 } };
            for (int i = 0; i < nums.GetLength(0); i++) {
                for (int j = 0; j < nums.GetLength(1); j++) {
                    Console.Write(nums[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
