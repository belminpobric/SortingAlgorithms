using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class SwapData
    {
        public static void Swap(int[] numbers, int left, int right)
        {
            int temp = numbers[right];
            numbers[right] = numbers[left];
            numbers[left] = temp;
        }
    }
}
