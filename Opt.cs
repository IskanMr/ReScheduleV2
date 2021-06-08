using System;
namespace ReSchedule{
    public class Opt : Def2{
        public override void Menu(){
            while (true){
                Console.Write("\nPilihan anda: "); 
                string op = Console.ReadLine();
                switch (op){
                    case "1":
                        new UserOpt().Fungsi();
                        break;
                    case "0":
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
        public override void Fungsi(){
            while (true){
                Console.Write("\nPilihan anda: "); 
                string op = Console.ReadLine();
                switch (op){
                    case "1":
                        Func.Add("Tugas");
                        new UserOpt().Fungsi();
                        break;
                    case "2":
                        Func.Delete("Tugas");
                        new UserOpt().Fungsi();
                        break;
                    case "3":
                        string opt = "1";
                        while (opt != "0"){
                            Func.Show("Tugas");
                            Console.Write("Ketik 0 untuk kembali! ");
                            opt = Console.ReadLine();
                        }
                        new UserOpt().Fungsi();
                        break;
                    case "0":
                        new UserOpt().Menu();
                        break;
                    default:
                        Shows.delay("Pilihan Salah! ");
                        new UserOpt().Fungsi();
                        break;
                }
                Shows.entry(Entries.entries2);
            }
        }
    }
}