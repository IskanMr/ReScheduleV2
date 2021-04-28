using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReSchedule
{
    class Sort
    {
        public static List<Tugas> linearSort(List<Tugas> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (list[j - 1].Durasi > list[j].Durasi)
                    {
                        Tugas temp = list[j - 1];
                        list[j - 1] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;
        }
    }
}
