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
            UserOpt x = new UserOpt();
            while (true)
            {
                Shows.entry(Entries.entries3);
                Console.Write("Pilihan Anda: ");
                string opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        Func.Pick("User");
                        break;
                    case "2":
                        Func.Add("User");
                        Main();
                        break;
                    case "3":
                        Func.Delete("User");
                        Main();
                        break;
                    case "0":
                        Shows.delay("Bye bye " + User.getName() + " ~");
                        Environment.Exit(0);
                        break;
                    default:
                        Shows.delay("Pilihan Salah! ");
                        Main();
                        break;
                }
            }
        }
    }
}
