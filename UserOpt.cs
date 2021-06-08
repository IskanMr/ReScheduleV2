namespace ReSchedule
{
    public class UserOpt : Def2
    {
        public override void Menu()
        {
            Shows.entry(Entries.entries1);
            Opt y = new Opt();
            y.Menu();
        }
        public override void Fungsi()
        {
            Shows.entry(Entries.entries2);
            Opt y = new Opt();
            y.Fungsi();
        }
    }
}
