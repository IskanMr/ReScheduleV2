using ConsoleTables;
using Microsoft.Data.SqlClient;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.Clear();
                Show();

                Console.Write("Nama " + obj + " \t\t: ");
                string a = Console.ReadLine();

                Console.Write("Durasi " + obj + " (Hari) \t: ");
                int b = Convert.ToInt16(Console.ReadLine());

                User.taskList.Add(new Tugas() { Nama=a, Durasi=b }) ;
                context.listTugas.Add(new Tugas() { Nama = a, Durasi = b, Deadline = Func.GetDeadl(b) });
                context.SaveChanges();

                Console.WriteLine("\nKetik 0 untuk kembali! ");
                opt = Console.ReadLine();
            }
        }

        public static void Delete(string obj)
        {
            using ReScContext context = new ReScContext();
            string opt = "1";
            while (opt != "0")
            {
                    Console.Clear();
                    Show();
                    Console.WriteLine("Pilih ID " + obj + " yang ingin dihapus: ");
                    int ops = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();
                    var s = new Tugas { ID = ops };
                    context.listTugas.Remove(s);
                context.SaveChanges();
                Show();
                    Console.WriteLine("Ketik 0 untuk kembali! ");
                    opt = Console.ReadLine(); 
            }
        }

        public static void Show()
        {
            using ReScContext context = new ReScContext();

            var listtugas = context.listTugas.OrderBy(p => p.Durasi);

            ConsoleTable
            .From(listtugas)
            .Write();
            Console.WriteLine("\n");
        }
        public static string GetDeadl(int Durasi)
        {
            DateTime dt = DateTime.Today.AddDays(Durasi);
            return dt.ToShortDateString();
        }

        public static void deleteRow(string table, string columnName, string IDNumber)
        {
            try
            {
                string MyConnection2 = "datasource=localhost;port=3307;username=root;password=root";
                string Query = "DELETE FROM " + table + " WHERE " + columnName + " = '" + IDNumber +"';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                Console.WriteLine("Data Deleted");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
    }
}
