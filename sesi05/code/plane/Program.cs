using System;

namespace plane
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesawat.class_pesawat pesawat = new Pesawat.class_pesawat();
            pesawat.nama = "Garuda";
            pesawat.ketinggian="2500 Kaki";

            pesawat.terbang();
            pesawat.sudahTerbang();
            Console.Read();
        }
    }
}
