using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReSchedule
{
    public class User : Thing
    {
        private static int Id;
        private static string Name;
        private static List<Tugas> TaskList = new List<Tugas>();
        private static string objek = "Tugas";

        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }
        public string Nama
        {
            get { return Name; }
            set { Name = value; }
        }
        public static string Objek
        {
            get { return objek; }
            set { objek = value; }
        }
        public static List<Tugas> taskList
        {
            get { return TaskList; }
            set { TaskList = value; }
        }

        public static void addTask() => Func.Add(Objek);
        public static void deleteTask() => Func.Delete(Objek);
        public static void showTask()
        {
            string opt = "1";
            while (opt != "0")
            {
                Func.Show();
                Console.Write("Ketik 0 untuk kembali! ");
                opt = Console.ReadLine();
            }
        }

        public static string getName() => Name;
    }
}
