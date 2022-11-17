using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int[] Arr = new int[9] { 2, 3, 1, 5, 4, 6, 0, 20, 14 };
            var Minx = 0;
            Find( Arr, ref Minx);
        }

        private static void Find(int[] Arr, ref int Minx)
        {
            Minx = Int32.MaxValue;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] < Minx)
                {
                    Minx = Arr[i];
                }
            }
            Console.WriteLine(Minx);
            Console.ReadLine();
        }

    }
}
