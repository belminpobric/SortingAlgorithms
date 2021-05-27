using InsertionSort;
using Logger;
using QuickSort;
using RadixSort;
using System;
using Ninject;
using SimpleInjector;

namespace SortingAlgorithms
{
     class Program
    {
        static readonly Ninject.IKernel kernel = new StandardKernel();
        static void Main(string[] args)

        {
            kernel.Bind<ILogger>().To<ConsoleLog>();
            kernel.Bind<ISortQuick>().To<SortQuick>();
            kernel.Bind<ISortInsertion>().To<Insertion>();
            kernel.Bind<ISortRadix>().To<SortRadix>();
            kernel.Bind<IArray>().To<Logger.Array>();

            var logger = kernel.Get<ConsoleLog>();
            var array = kernel.Get<Logger.Array>();
            var sortquick = kernel.Get<SortQuick>();
            var sortInsertion = kernel.Get<Insertion>();
            var sortRadix = kernel.Get<SortRadix>();

            logger.Write("\nProgram for sorting a numeric array using Quick Sorting");
            logger.Write("\n\nEnter number of elements: ");
            int max = Convert.ToInt32(Console.ReadLine());
            int [] numbers = array.Initialize(max);

            
            logger.Write("Input int array  : ");
            logger.Write("\n");

            array.Print(max, numbers);

            logger.Write("QuickSort By Recursive Method");

            sortquick.Sort(numbers, 0, max - 1);
            
            logger.Write("\n");
            
            array.Print(max, numbers);

            logger.Write("-----Sorting by InsertionSort-------");

            int[] sortedArrayInsertion = sortInsertion.Sort(numbers, max);

            logger.Write("\nSorted Array is: ");

            array.Print(max, sortedArrayInsertion);

            logger.Write("-----Sorting by RadixSort-------");

            int[] sortedArrayRadix= sortRadix.Sort(numbers, max);

            logger.Write("\nSorted Array is: ");

            array.Print(max, sortedArrayRadix);

            Console.ReadLine();

        }


        
    }
    
        

}
