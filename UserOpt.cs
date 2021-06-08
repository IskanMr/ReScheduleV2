namespace ReSchedule{
    public class UserOpt : Def2{
        public override void Menu(){
            Shows.entry(Entries.entries1); 
            new Opt().Menu();
        }
        public override void Fungsi(){
            Shows.entry(Entries.entries2); 
            new Opt().Fungsi();
        }
    }
}
