using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReSchedule{
    public class User : Thing{
        private static int id;
        private static string Name;
        private ICollection<Tugas> listTugas;
        public int Id{
            get { return id; }
            set { id = value; }
        }
        public ICollection<Tugas> ListTugas{
            get { return listTugas; }
            set { listTugas = value; }
        }
        public string Nama{
            get { return Name; }
            set { Name = value; }
        }
        public static string getName() => Name;
        public static int getId() => id;
    }
}
