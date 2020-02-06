using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;


namespace Sorteringsalgoritmer
{
    class Sortering
    {
        public double Bubble(List<int> bubblesort)
        {
            Stopwatch bubblewatch = new Stopwatch();
            bubblewatch.Start();
            for (int i = 0; i < bubblesort.Count - 1; i++)
            {
                for (int j = 0; j < bubblesort.Count - 1; j++)
                {
                    if (bubblesort[j] > bubblesort[j + 1])
                    {
                        int temp = bubblesort[j];
                        bubblesort[j] = bubblesort[j + 1];
                        bubblesort[j + 1] = temp;
                    }
                }
            }
            bubblewatch.Stop();
            return bubblewatch.Elapsed.TotalMilliseconds;
        }
    }
}
