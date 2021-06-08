using System;
namespace ReSchedule{
    public class Program{
        public static void Main(){
            Console.Title = "reSchedule";
            while (true){
                Console.Clear();
                Shows.entry(Entries.entries3);
                Console.Write("Pilihan Anda: "); 
                string opt = Console.ReadLine();
                switch (opt){
                    case "1":
                        Func.Pick("User");
                        break;
                    case "2":
                        Func.Add("User");
                        break;
                    case "3":
                        Func.Delete("User");
                        break;
                    case "0":
                        Shows.delay("Bye bye " + User.getName() + " ~");
                        Environment.Exit(0);
                        break;
                    default:
                        Shows.delay("Pilihan Salah!");
                        break;
                }
            }
        }
    }
}
