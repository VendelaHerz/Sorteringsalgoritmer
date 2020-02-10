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
                while (j >= 0 && insertionSort[j] > x)
                {
                    insertionSort[j + 1] = insertionSort[j];
                    j--;
                }
                insertionSort[j + 1] = x;
            }
            insertionWatch.Stop();
            return insertionWatch.Elapsed.TotalMilliseconds;
        }

        public double Merge1(List<int> mergeSort)
        {
            Stopwatch mergeWatch = new Stopwatch();
            mergeWatch.Start();
            List<int> SorteradLista = Merge2(mergeSort);
            mergeWatch.Stop();
            return mergeWatch.Elapsed.TotalMilliseconds;
        }
        private List<int> Merge2(List<int> mergeSort)
        {
            List<int> vänster = new List<int>();
            List<int> höger = new List<int>();

            if (mergeSort.Count <= 1)
            {
                return mergeSort;
            }

            int x = mergeSort.Count / 2;
            vänster = mergeSort.GetRange(0, x);
            höger = mergeSort.GetRange(x, mergeSort.Count - x);

            vänster = Merge2(vänster);
            höger = Merge2(höger);

            return Merge3(vänster, höger);
        }

        private List<int> Merge3(List<int> vänster, List<int> höger)
        {
            List<int> result = new List<int>();

            while (vänster.Count > 0 && höger.Count > 0)
            {
                if (vänster[0] <= höger[0])
                {
                    result.Add(vänster[0]);
                    vänster = vänster.GetRange(1, vänster.Count - 1);
                }
                else
                {
                    result.Add(höger[0]);
                    höger = höger.GetRange(1, höger.Count - 1);
                }
            }
        
            if (vänster.Count > 0)
            {
                result.AddRange(vänster);
            }
            else
            {
                result.AddRange(höger);
            }
            return result;
        }

        public double Quick1(List<int> quickSort)
        { 
            Stopwatch quickWatch = new Stopwatch();
            quickWatch.Start();
            Quick2(quickSort, 0, quickSort.Count - 1);
            quickWatch.Stop();
            return quickWatch.Elapsed.TotalMilliseconds;
        }
        private void Quick2(List<int> quickSort, int low, int high)
        {
            if (low < high)
            {
                int p;
                p = Partition(quickSort, low, high);
                Quick2(quickSort, low, p - 1);
                Quick2(quickSort, p + 1, high);
            }
        }
        private int Partition(List<int> quickSort, int low, int high)
        {
            int pivot = quickSort[high];
            int i = low;
            for (int j = low; j < high; j++)
            {
                if (quickSort[j] < pivot)
                {
                    int a = quickSort[i];
                    quickSort[i] = quickSort[j];
                    quickSort[j] = a;
                    i++;
                }
            }
            int b = quickSort[i];
            quickSort[i] = quickSort[high];
            quickSort[high] = b;
            return i;
        }
        public double C(List<int> cSort)
        {
            Stopwatch cWatch = new Stopwatch();
            cWatch.Start();
            cSort.Sort();
            cWatch.Stop();
            return cWatch.Elapsed.TotalMilliseconds;
        }
    }
}
