using System;

public class Test{

    public static void Main(string[] args){

        string[] contoh = new string[4] {"Motherboard", "Processor", "Power Supply", "Video Card"};

        Console.WriteLine("Menampilkan semua data dalam array\n");

        foreach (string contoh1 in contoh)
        {
            Console.WriteLine(contoh1);
        }

        Console.Write("Press any key to continue . . .");
        Console.ReadLine();
    }
}