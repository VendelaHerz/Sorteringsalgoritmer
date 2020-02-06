using System;
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
            Sortering sortering = new Sortering();
            List<int> nummerlista = new List<int>();
            Random nummer = new Random();
            for (int i = 0; i < 1_0; i++)
            {
                int num = nummer.Next(1, 100001);
                nummerlista.Add(num);
            }
            List<int> bubblesort = new List<int>(nummerlista);

            double bubbletime = sortering.Bubble(bubblesort);
            Console.WriteLine("Bubblesort tid: " + bubbletime + " millisekunder");

        }
        
    }
}
    
