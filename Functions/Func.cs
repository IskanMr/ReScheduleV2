using ConsoleTables;
using System;
using System.Linq;

namespace ReSchedule
{
    class Func
    {
        public static void Add(string obj)
        {
            using ReScContext context = new ReScContext();
            string x = User.getName();
            string opt = "1";
            while (opt != "0")
            {
                bool op = true;
                while (op)
                {
                    Console.Clear();
                    Show(obj);
                    Console.Write("Nama " + obj + " / 0 untuk kembali\t: ");
                    string a = Console.ReadLine();
                    if (a == "0")
                    {
                        opt = "0";
                        op = false;
                    }
                    else
                    {
                        if (obj == "Tugas")
                        {
                            Console.Write("Durasi " + obj + " (Hari) \t\t: ");
                            int b = Convert.ToInt32(Console.ReadLine());
                            context.listTugas.Add(new Tugas() { Nama = a, Durasi = b, Deadline = Tugas.GetDead(b), userId = User.getId()});
                            context.SaveChanges();
                        } 
                        else if(obj == "User")
                        {
                            context.Users.Add(new User() { Nama = a});
                            context.SaveChanges();
                        }
                    }
                }
            }
        }

        public static void Delete(string obj)
        {
            using ReScContext context = new ReScContext();
            string opt = "1";
            while (opt != "0")
            {
                bool op = true;
                while (op)
                {
                    Console.Clear();
                    Show(obj);
                    Console.Write("Pilih Id " + obj + " yang ingin dihapus / 0 untuk kembali: ");
                    int ops = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (ops == 0)
                    {
                        opt = "0";
                        op = false;
                    }
                    else
                    {
                        if (obj == "Tugas")
                        {
                            foreach(Tugas tugas in context.listTugas)
                            {
                                if (tugas.Id == ops)
                                {
                                    context.listTugas.Remove(tugas);
                                    op = false;
                                }
                                else
                                {
                                    Console.Clear();
                                    Shows.delay("Id yang dimasukan Salah!");
                                }
                            }
                        } 
                        else if (obj == "User")
                        {
                            bool x = false;
                            User newUs = new User();
                            foreach(User user in context.Users)
                            {
                                if (user.Id == ops)
                                {
                                    newUs = user;
                                    x = true;
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Shows.delay("Id yang dimasukan Salah!");
                                }
                            }
                            if (x)
                            {
                                foreach (Tugas tugas in context.listTugas)
                                {
                                    if (tugas.userId == ops)
                                    {
                                        context.listTugas.Remove(tugas);
                                    }
                                }
                                context.Users.Remove(newUs);
                                op = false;
                            }
                        }
                    }                    
                    context.SaveChanges();
                    Show(obj);
                }
            }
        }

        public static void Show(string obj)
        {
            using ReScContext context = new ReScContext();
            bool op = true;
            while (op)
            {
                Console.WriteLine("List " + obj);
                if (obj == "Tugas")
                {
                    var listtugas = context.listTugas.Where(e => e.userId == User.getId()).OrderBy(p => p.Durasi);
                    var table = new ConsoleTable("Id", "Nama", "Deadline");

                    foreach (Tugas tugas in listtugas)
                    {
                        table.AddRow(tugas.Id, tugas.Nama, tugas.Deadline);
                    }
                    table.Write();
                    op = false;
                }
                else if(obj == "User")
                {
                    var users = context.Users;
                    var table = new ConsoleTable("Id", "Nama");

                    foreach (User user in users)
                    {
                        table.AddRow(user.Id, user.Nama);
                    }
                    table.Write();
                    op = false;
                }      
            }
            Console.WriteLine("\n");
        }

        public static void Pick(string obj)
        {
            using ReScContext context = new ReScContext();
            string opt = "1";
            while (opt != "0")
            {
                bool op = true;
                while (op)
                {
                    Console.Clear();
                    Show(obj);
                    Console.Write("Pilih Id " + obj + " yang diinginkan / 0 untuk kembali: ");
                    int ops = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (ops == 0)
                    {
                        opt = "0";
                        op = false;
                    }
                    else
                    {
                        if (obj == "User")
                        {
                            UserOpt x = new UserOpt();
                            foreach (User usert in context.Users)
                            {
                                if (usert.Id == ops)
                                {
                                    User user = usert;
                                    x.Menu();
                                }
                                else
                                {
                                    Console.Clear();
                                    Shows.delay("Id tidak valid");
                                }
                            }
                        }                        
                    }
                }               
            }
        }
    }
}
