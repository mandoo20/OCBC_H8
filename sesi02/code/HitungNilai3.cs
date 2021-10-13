using System;

class HitungNilai3
{
    public static void Main(string[] args){
        int nilai1 = 10,nilai2 = 8;

        nilai1 = 15;
        Console.WriteLine($"nilai1 = {nilai1}");

        nilai2 +=6;
        Console.WriteLine($"nilai2 = {nilai2}");

        Console.WriteLine("\nHasil perbandingan:");
        
        Console.WriteLine("nilai1 > nilai2 : " + (nilai1 > nilai2 ? true : false));
        Console.WriteLine("nilai1 >= nilai2 : " + (nilai1 >= nilai2 ? true : false));
        Console.WriteLine("nilai1 < nilai2 : " + (nilai1 < nilai2 ? true : false));
        Console.WriteLine("nilai1 <= nilai2 : " + (nilai1 <= nilai2 ? true : false));
        Console.WriteLine("nilai1 == nilai2 : " + (nilai1 == nilai2 ? true : false));
        Console.WriteLine("nilai1 != nilai2 : " + (nilai1 != nilai2 ? true : false));


    }
}