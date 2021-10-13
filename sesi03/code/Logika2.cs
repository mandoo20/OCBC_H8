using System;

class logika2{
    
    public static void Main(){
        int nilai;

        Console.Write("Masukan Nilai Calculus Anda: ");
        nilai = int.Parse(Console.ReadLine());

        if (nilai < 60) {
            Console.WriteLine("Nilai Kamu C");
        }
        else if (nilai <80) {
            Console.WriteLine("Nilai Kamu B"); 
        }
        else{
            Console.WriteLine("Nilai Kamu A");
        }
    }
}