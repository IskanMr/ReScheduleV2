using System;

namespace ReSchedule
{
    public class Tugas : Def1, Thing
    {
        private int ID;
        private int UserId;
        private string Name;
        private int Duration;
        private string deadline;
        public int userId
        {
            get { return UserId; }
            set { UserId = User.getId(); }
        }
        public int Id
        {
            get { return ID; }
            set { ID = value; }
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
                deadline = GetDead(Durasi);
            }
        }
        public static string GetDead(int Durasi)
        {
            DateTime dt = DateTime.Today.AddDays(Durasi);
            return dt.ToShortDateString();
        }
        public override string getName() => Nama;

    }
}
