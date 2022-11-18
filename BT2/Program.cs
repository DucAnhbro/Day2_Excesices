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
            int[] Arr = new int[9] { 2, 3, 1, 5, 4, 6, 8, 20, 14 };
            var Minx = Int32.MaxValue;
            Find( Arr, ref Minx);
        }

        
        private static void Find(int[] Arr, ref int Minx)
        {         
                if(Arr.Length > 1)
                {
                   // Minx = Int32.MaxValue;
                    for (int i = 0; i < Arr.Length; i++)
                    {
                        if (Arr[i] < Minx)
                        {
                            Minx = Arr[i];
                        }
                    }
                    Console.WriteLine(Minx);
                }
                else
                {
                    Console.WriteLine("Array not exit emty");
                }
            Console.ReadLine();
        }

    }
}
