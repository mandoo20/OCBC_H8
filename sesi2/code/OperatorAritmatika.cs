using System;

class OperatorAritmatika
{
    public static void Main(string[] args)
    {
        int a,b,c,total;
        double avg;


        Console.WriteLine("\n===Menghitung Nilai===");
        Console.Write("Masukan nilai PERTAMA: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Masukan nilai KEDUA: ");
        b = int.Parse(Console.ReadLine());

        Console.Write("Masukan nilai KETIGA: ");
        c = int.Parse(Console.ReadLine());
        
        total = a+b+c;
        avg = total/3.0;
        Console.WriteLine("\nTotal Nilai adalah: "+total);
        Console.WriteLine("Rata Rata Nilai adalah: "+avg);
        
    }
}