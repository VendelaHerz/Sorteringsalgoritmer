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
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            if (mergeSort.Count <= 1)
            {
                return mergeSort;
            }

            int x = mergeSort.Count / 2;
            left = mergeSort.GetRange(0, x);
            right = mergeSort.GetRange(x, mergeSort.Count - x);

            left = Merge2(left);
            right = Merge2(right);

            return Merge3(left, right);
        }

        private List<int> Merge3(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0] <= right[0])
                {
                    result.Add(left[0]);
                    left = left.GetRange(1, left.Count - 1);
                }
                else
                {
                    result.Add(right[0]);
                    right = right.GetRange(1, right.Count - 1);
                }
            }
        
            if (left.Count > 0)
            {
                result.AddRange(left);
            }
            else
            {
                result.AddRange(right);
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
