﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;


namespace Sorteringsalgoritmer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många element ska listan innehålla?");
            int element = int.Parse(Console.ReadLine());
            Sortering sortering = new Sortering();
            List<int> nummerLista = new List<int>();
            Random nummer = new Random();
            for (int i = 0; i < element; i++)
            {
                int num = nummer.Next(1, 100001);
                nummerLista.Add(num);
            }
            List<int> bubbleSort = new List<int>(nummerLista);
            List<int> insertionSort = new List<int>(nummerLista);
            List<int> mergeSort = new List<int>(nummerLista);
            List<int> quickSort = new List<int>(nummerLista);
            List<int> cSort = new List<int>(nummerLista);

            double bubbleTime = sortering.Bubble(bubbleSort);
            Console.WriteLine("Bubblesort tid: " + bubbleTime + " millisekunder");

            double insertionTime = sortering.Insertion(insertionSort);
            Console.WriteLine("Insertionsort tid: " + insertionTime + " millisekunder");

            double mergeTime = sortering.Insertion(mergeSort);
            Console.WriteLine("Mergesort tid: " + mergeTime + " millisekunder");

            double quickTime = sortering.Quick(quickSort);
            Console.WriteLine("Quicksort tid: " + quickTime + " millisekunder");

            double cTime = sortering.C(cSort);
            Console.WriteLine("Csort tid: " + cTime + " millisekunder");
        }

    }
}
    
