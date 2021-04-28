using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReSchedule
{
    public class Tugas : Def1, Thing
    {
        private int Id;
        private string Name;
        private int Duration;
        private string deadline;
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
        public int Durasi
        {
            get { return Duration; }
            set { Duration = value; }
        }
        public string Deadline
        {
            get { return deadline; }
            set 
            {
                deadline = Func.GetDeadl(Durasi);
            }
        }

        public User User { get; set; }

        public override string getName() => Nama;

    }
}
