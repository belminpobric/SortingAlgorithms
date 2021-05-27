using System;

namespace InsertionSort
{
    public class Insertion : ISortInsertion
    {
        public int[] Sort(int[] arr, int max) 
        {
            for (int i = 1; i < max; i++)
            {
                int val, flag;
                val = arr[i];
                flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            return arr;
        }
    }
}
