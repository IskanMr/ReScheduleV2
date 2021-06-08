using System;
using System.Threading;

namespace ReSchedule
{
    class Shows
    {
        public static void entry(Entry[] entries)
        {
            Console.Clear();
            Console.WriteLine("Pilihan: ");
            foreach (Entry entry in entries)
            {
                Console.WriteLine("\t[" + entry.getKey() + "] - " + entry.getName());
            }
            Console.WriteLine("\n");
        }
        public static void delay(string words)
        {
            Console.Clear();
            Console.WriteLine(words);
            Thread.Sleep(1000);
        }
    }
}
