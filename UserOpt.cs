using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReSchedule
{
    public class UserOpt : Def2
    {
        public override void Menu()
        {
            Show.entry(Entries.entries1);
            Opt y = new Opt();
            y.Menu();
        }

        public override void Fungsi()
        {
            Show.entry(Entries.entries2);
            Opt y = new Opt();
            y.Fungsi();
        }
    }
}
