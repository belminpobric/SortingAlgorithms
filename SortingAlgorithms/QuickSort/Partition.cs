using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
     abstract class Partition 
    {
        public static int PartitionArray(int[] numbers, int left, int right)
        {
            while (true)
            {
                while (numbers[left] < Pivot.FindPivot(numbers, left))
                    left++;

                while (numbers[right] > Pivot.FindPivot(numbers, left))
                    right--;

                if (left < right)

                {
                    SwapData.Swap(numbers,left,right);
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
