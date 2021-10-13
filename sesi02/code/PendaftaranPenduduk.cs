using System;

class PendaftaranPenduduk
{
    public static void Main(string[] args)
    {
        string nama,alamat;
        int umur;

        Console.WriteLine("=== PROGRAM PENDAFTARAN PENDUDUK ===");
        Console.Write("Masukan nama: ");
        nama = Console.ReadLine();

        Console.Write("Masukan alamat: ");
        alamat = Console.ReadLine();

        Console.Write("Masukan umur: ");
        umur = int.Parse(Console.ReadLine());

        Console.WriteLine("\nTerimakasih!\nData Berikut");
        Console.WriteLine("Nama: "+nama);
        Console.WriteLine("Alamat: "+alamat);
        Console.WriteLine("Umur: "+umur);
        Console.WriteLine("SUDAH DISIMPAN");

    }
}