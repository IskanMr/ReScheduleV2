using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                if (op == "1" || op == "menu")
                {
                    x.Fungsi();
                }
                else if (op == "0" || op == "exit")
                {
                    Show.delay("Bye bye " + User.getName() + "~");
                    Environment.Exit(0);
                }
                else
                {
                    Show.delay("Pilihan Salah! ");
                    Program.Main();
                }
                if (op == "e")
                {
                    break;
                }
                Show.entry(Entries.entries1);
            }
        }

        public override void Fungsi()
        {
            UserOpt x = new UserOpt();
            while (true)
            {
                Console.Write("\nPilihan anda: ");
                string op = Console.ReadLine().ToLower();

                if (op == Entries.entries2[0].getKey().ToLower() || op == Entries.entries2[0].getName().ToLower())
                {
                    Console.Clear();
                    User.addTask();
                    x.Fungsi();
                }
                else if (op == Entries.entries2[1].getKey().ToLower() || op == Entries.entries2[1].getName().ToLower())
                {
                    Console.Clear();
                    User.deleteTask();
                    x.Fungsi();
                }
                else if (op == Entries.entries2[2].getKey().ToLower() || op == Entries.entries2[2].getName().ToLower())
                {
                    Console.Clear();
                    User.showTask();
                    x.Fungsi();
                }
                else if (op == Entries.entries2[3].getKey().ToLower() || op == Entries.entries2[3].getName().ToLower())
                {
                    Console.Clear();
                    x.Menu();
                }
                else
                {
                    Show.delay("Pilihan Salah! ");
                    x.Fungsi();
                }
                if (op == "e")
                {
                    break;
                }
                Show.entry(Entries.entries2);
            }
        }
    }
}
