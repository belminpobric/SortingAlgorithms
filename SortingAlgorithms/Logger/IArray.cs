using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public interface IArray 
    {

        int[] Initialize(int max);
        void Print(int max, int[] numbers);
    }
}
