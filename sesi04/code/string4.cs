using System;

class string4{
    static void Main(){
        string stringAwal = "C# membuat string mudah.";

        //Menciptakan sebuah substring.
        string substr = stringAwal.Substring(5,12);

        Console.WriteLine("string Awal: " + stringAwal);
        Console.WriteLine("substring: " + substr);
    }
}