using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Array : IArray
    {
        ILogger logger = new ConsoleLog();
        public int[] Initialize(int max)
        {
            int[] numbers = new int[max];
            for (int i = 0; i < max; i++)

            {
                logger.Write("\nEnter [" + (i + 1).ToString() + "] element: ");

                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }
            return numbers;
        }
        public void Print(int max,int [] numbers)
        {
            for (int k = 0; k < max; k++)
            {
                logger.Write(numbers[k] + " ");
                logger.Write("\n");

            }
        }
        
    }
}
