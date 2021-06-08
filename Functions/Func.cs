using ConsoleTables;
using System;
using System.Linq;

namespace ReSchedule{
    class Func{
        public static void Add(string obj){
            using ReScContext context = new ReScContext();
            string opt = "1";
            while (opt != "0"){ 
                Show(obj);
                Console.Write("Nama " + obj + " / 0 untuk kembali\t: "); 
                opt = Console.ReadLine();
                if(opt!="0"){
                    if (obj == "Tugas"){
                        Console.Write("Durasi " + obj + " (Hari) \t\t: "); 
                        int b = Convert.ToInt32(Console.ReadLine());
                        context.listTugas.Add(new Tugas() { Nama = opt, Durasi = b, Deadline = Tugas.GetDead(b), userId = User.getId()});
                    } 
                    else if (obj == "User") 
                        context.Users.Add(new User { Id = 0, Nama = opt });                    
                    context.SaveChanges();
                }          
            }
        }
        public static void Delete(string obj){
            using ReScContext context = new ReScContext();
            string opt = "1";
            while (opt != "0"){
                Show(obj);
                Console.Write("Pilih Id " + obj + " yang ingin dihapus / 0 untuk kembali: ");
                opt = Console.ReadLine(); 
                int ops = Convert.ToInt32(opt);
                if (opt!="0"){
                    bool x = false;
                    if (obj == "Tugas"){
                        Tugas newTu = new Tugas();
                        foreach (Tugas tugas in context.listTugas){
                            if (tugas.Id == ops){
                                newTu = tugas;
                                x = true;
                                break;
                            }
                        }
                        if (!x){
                            Shows.delay("Id " + ops + " tidak ditemukan!");
                            Delete(obj);
                        }
                        context.listTugas.Remove(newTu);
                    }
                    else if (obj == "User"){
                        User newUs = new User();
                        foreach (User user in context.Users){
                            if (user.Id == ops){
                                newUs = user;
                                x = true;
                                break;
                            }
                        }
                        if (!x){
                            Shows.delay("Id " + ops + " tidak ditemukan!");
                            Delete(obj);
                        }
                        foreach (Tugas tugas in context.listTugas){
                            if (tugas.userId == ops) 
                                context.listTugas.Remove(tugas);
                        }
                        context.Users.Remove(newUs);                         
                    }
                    context.SaveChanges();
                    Show(obj);
                }
            }
        }
        public static void Show(string obj){
            using ReScContext context = new ReScContext();
                Console.Clear();
                Console.WriteLine("List " + obj);
            var table = new ConsoleTable("Id", "Nama");
            if (obj == "Tugas"){
                    var listtugas = context.listTugas.Where(e => e.userId == User.getId()).OrderBy(p => p.Durasi);
                    table = new ConsoleTable("Id", "Nama", "Deadline");
                    foreach (Tugas tugas in listtugas) 
                        table.AddRow(tugas.Id, tugas.Nama, tugas.Deadline);
                    table.Write();
                }
                else if (obj == "User"){
                    foreach (User user in context.Users) table.AddRow(user.Id, user.Nama);
                    table.Write();
                }
            Console.WriteLine("\n");
        }
        public static void Pick(string obj)
        {
            using ReScContext context = new ReScContext();
            int opt = 1;
            while (opt != 0)
            {
                Show(obj);
                Console.Write("Pilih Id " + obj + " yang diinginkan / 0 untuk kembali: ");
                opt = Convert.ToInt32(Console.ReadLine());
                if (opt != 0)
                {
                    foreach (User user in context.Users)
                        if (user.Id == opt)
                            new UserOpt().Menu();
                    Shows.delay("Id tidak valid");
                }
            }
        }
    }
}
