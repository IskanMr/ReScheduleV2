using System;

namespace ReSchedule
{
    public class Program
    {
        public static void Main()
        {
            using ReScContext context = new ReScContext();
            Console.Clear();
            Console.Title = "reSchedule";

            Console.Write("Nama anda: ");
            string Nama = Console.ReadLine();

            context.Add(new User { Nama = Nama });

            UserOpt x = new UserOpt();
            x.Menu();
        }
    }
}
