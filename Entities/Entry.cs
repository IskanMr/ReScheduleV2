namespace ReSchedule
{
    class Entry : Def1, Thing
    {
        private string Name { get; set; }
        private string Key { get; set; }
        public string Nama { get { return Name; } set { Name = value; } }

        public Entry(string name, string key)
        {
            Name = name;
            Key = key;
        }

        public override string getName() => Name;

        public string getKey() => Key;
    }
}
