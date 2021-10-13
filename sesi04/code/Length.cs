using System;

class Length{

    static void Main(){

        int[] angka = new int[10];

        Console.WriteLine("panjang Array: "+angka.Length);

        for(int i=0;i<angka.Length;i++){
            angka[i] =i*i;
        }

        Console.Write("Angka dalam Array: ");
        for(int i=0;i<angka.Length;i++){
            Console.Write(angka[i]+" ");
        }

        Console.WriteLine("");
    }
}