using System;

public static class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        Console.WriteLine("Hello Armando");
        Console.WriteLine("Selamat datang di Program Bootcamp OCBC");
        Console.WriteLine("Tahap 1 saya akan belajar C#");

        string namaCustomer = "foxi";
        double harga1 = 10.000, harga2= 5.000, harga3 = 20.000;
        int jumlah1 = 10, jumlah2 = 7, jumlah3 = 12;

        double total1 = harga1*jumlah1;
        double total2 = harga2*jumlah2;
        double total3 = harga3*jumlah3;

        double totalHargaSemuaBarang = total1+total2+total3;
        int jumlahSemuaBarang = jumlah1+jumlah2+jumlah3;

        Console.WriteLine("\nNama Customer : " + namaCustomer);
        Console.WriteLine("Barang 1 ber jumlah : "+jumlah1+ " dengan harga "+harga1+", yang harus dibayar "+total1);
        Console.WriteLine("Barang 2 ber jumlah : "+jumlah2+ " dengan harga "+harga2+", yang harus dibayar "+total2);
        Console.WriteLine("Barang 3 ber jumlah : "+jumlah3+ " dengan harga "+harga3+", yang harus dibayar "+total3);
        Console.WriteLine("\nJumlah semua barang : "+jumlahSemuaBarang);
        Console.WriteLine("Total harga semua barang : "+totalHargaSemuaBarang+"\n");


    }
}