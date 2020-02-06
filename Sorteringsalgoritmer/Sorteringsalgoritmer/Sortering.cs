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
        public double Bubble(List<int> bubbleSort)
        {
            Stopwatch bubbleWatch = new Stopwatch();
            bubbleWatch.Start();
            for (int i = 0; i < bubbleSort.Count - 1; i++)
            {
                for (int j = 0; j < bubbleSort.Count - 1; j++)
                {
                    if (bubbleSort[j] > bubbleSort[j + 1])
                    {
                        int temp = bubbleSort[j];
                        bubbleSort[j] = bubbleSort[j + 1];
                        bubbleSort[j + 1] = temp;
                    }
                }
            }
            bubbleWatch.Stop();
            return bubbleWatch.Elapsed.TotalMilliseconds;
        }

        public double Insertion(List<int> insertionSort)
        {
            Stopwatch insertionWatch = new Stopwatch();
            insertionWatch.Start();
            for (int i = 1; i < insertionSort.Count; i++)
            {
                int x = insertionSort[i];
                int j = i - 1;
                while (j >= 0 && insertionSort[j]>x)
                {
                    insertionSort[j + 1] = insertionSort[j];
                    j--;
                }
                insertionSort[j + 1] = x;
            }
            insertionWatch.Stop();
            return insertionWatch.Elapsed.TotalMilliseconds;
        }

        public double Merge1 (List<int> mergeSort)
        {
            Stopwatch mergeWatch = new Stopwatch();
            mergeWatch.Start();
            mergeWatch.Stop();
            return mergeWatch.Elapsed.TotalMilliseconds;
        }

        public double Quick(List<int> quickSort)
        {
            Stopwatch quickWatch = new Stopwatch();
            quickWatch.Start();
            quickWatch.Stop();
            return quickWatch.Elapsed.TotalMilliseconds;
        }
    }   
}
