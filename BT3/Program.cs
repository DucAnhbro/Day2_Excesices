using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
           // Convert.ToInt32(Console.ReadLine());
            string[] even = new string[] { "Event - Assign", "Event - View", "Event - Assign", "Event - Acept",
                "Event - Delete", "Event - Assign", "Event - Acept", "Event - Delete",
                "Event - Delete", "Event - View", "Event - Assign", "Event - Acept", "Event - Delete", "Event - Assign" };

           // [Event-Assign, Event - View, Event - Assign, Event - Acept, Event - Delete, Event - Assign, Event - Acept, Event - Delete,Event - Delete, Event - View, Event - Assign, Event - Acept, Event - Delete,Event - Assign]
            //string[] odd = new string[] { "Event - View", "Event - View",", "Event - Assign", "Event - Assign" };
            foreach (string s in even)
            {
                if(s.Equals("Event - Acept"))
                {
                    count ++;
                }
            }
            int count2 = 0;
            for (int i = 0; i < even.Length; i++)
            {
                if (even[i].Equals("Event - View") && even[i + 1].Equals("Event - Assign")
                    && even[i+2].Equals("Event - Acept") && even[i + 3].Equals("Event - Delete")
                    ) 
                {
                    count2++;
                }
            }
            Console.WriteLine("number of transactions:"+ count);
            Console.WriteLine("Number of even:" + count2);
            Console.ReadLine();
        }
    }
}
