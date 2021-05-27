using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class SortQuick : ISortQuick
    {
        public void Sort(int[] arr, int left, int right)
        {
            if (left < right)

            {
                int pivot = Partition.PartitionArray(arr, left, right);
                if (pivot > 1)
                    Sort(arr, left, pivot - 1);
                if (pivot + 1 < right)
                    Sort(arr, pivot + 1, right);

            }
        }
    }
}
