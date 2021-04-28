using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReSchedule
{
    class Show
    {
        public static void entry(Entry[] entries)
        {
            Console.Clear();
            Console.WriteLine("Pilihan: ");
            foreach (Entry entry in entries)
            {
                Console.WriteLine("\t[" + entry.getKey() + "] - " + entry.getName());
            }
        }

        public static void delay(string words)
        {
            Console.Clear();
            Console.WriteLine(words);
            Thread.Sleep(1000);
        }
    }
}
