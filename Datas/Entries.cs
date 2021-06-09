namespace ReSchedule{
    class Entries{
        public static Entry[] entries1 { get; set; } = new Entry[]{
            new Entry("Menu", "1"), new Entry("Kembali", "0"),
        };
        public static Entry[] entries2 { get; set; } = new Entry[]{
            new Entry("Tambahkan Tugas","1"), new Entry("Hapus Tugas", "2"), new Entry("Tunjukan Semua Tugas", "3"), new Entry("Kembali", "0")
        };
        public static Entry[] entries3 { get; set; } = new Entry[]{
            new Entry("Pilih Akun", "1"), new Entry("Tambah Akun", "2"), new Entry("Hapus Akun", "3"), new Entry("Keluar", "0")
        };
    }
}
