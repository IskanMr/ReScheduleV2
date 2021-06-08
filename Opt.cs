using System;

namespace ReSchedule
{
    public class Opt : Def2
    {
        public override void Menu()
        {
            UserOpt x = new UserOpt();
            while (true)
            {
                Console.Write("\nPilihan anda: ");
                string op = Console.ReadLine().ToLower();
                switch (op)
                {
                    case "1":
                    case "menu":
                        x.Fungsi();
                        break;
                    case "0":
                    case "kembali":
                        Program.Main();
                        break;
                    default:
                        Shows.delay("Pilihan Salah! ");
                        Menu();
                        break;
                }
                Shows.entry(Entries.entries1);
            }
        }
        public override void Fungsi()
        {
            UserOpt x = new UserOpt();
            while (true)
            {
                Console.Write("\nPilihan anda: ");
                string op = Console.ReadLine().ToLower();

                switch (op)
                {
                    case "1":
                    case "tambahkan":
                        Console.Clear();
                        Func.Add("Tugas");
                        x.Fungsi();
                        break;
                    case "2":
                    case "hapus":
                        Console.Clear();
                        Func.Delete("Tugas");
                        x.Fungsi();
                        break;
                    case "3":
                    case "tunjukan":
                        Console.Clear();
                        User.showTask();
                        x.Fungsi();
                        break;
                    case "0":
                    case "kembali":
                        Console.Clear();
                        x.Menu();
                        break;
                    default:
                        Shows.delay("Pilihan Salah! ");
                        x.Fungsi();
                        break;
                }
                Shows.entry(Entries.entries2);
            }
        }
    }
}
