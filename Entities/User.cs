using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReSchedule
{
    public class User : Thing
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private static int id;
        private static string Name;
        private ICollection<Tugas> listTugas;
        private static string objek = "Tugas";
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public ICollection<Tugas> ListTugas
        {
            get { return listTugas; }
            set { listTugas = value; }
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
        public static void showTask()
        {
            string op = "1";
            while (op == "1")
            {
                Func.Show(objek);
                Console.Write("Ketik 0 untuk kembali! ");
                op = Console.ReadLine();
            }
        }
        public static string getName() => Name;
        public static int getId() => id;
    }
}
