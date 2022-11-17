using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("");
            var n = Console.ReadLine();
            switch(n)
            {
                case "2":
                    Console.WriteLine("Thứ 2");
                    break;
                case "3":
                    Console.WriteLine("Thứ 3");
                    break;
                case "4":
                    Console.WriteLine("Thứ 4");
                    break;
                case "5":
                    Console.WriteLine("Thứ 5");
                    break;
                case "6":
                    Console.WriteLine("Thứ 6");
                    break;
                case "7":
                    Console.WriteLine("Thứ 7");
                    break;
                case "CN":
                    Console.WriteLine("CN");
                    break;
                default:
                    Console.WriteLine("sai, deo noi nhieu");
                    break;
            }
            Console.ReadLine();
        }
    }
}
