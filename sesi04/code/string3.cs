using System;

class string3{
    static void Main(){
        string[] str = {"Ini", "adalah", "sebuah", "test."};
        Console.WriteLine("Array asli: ");

        for(int i=0;i<str.Length;i++){
            Console.Write(str[i] + " ");
        }
        Console.WriteLine("\n");

        //menguba string.
        str[1] = "merupakan";
        str[3] = "test, juga!";
        Console.WriteLine("Array termodifikasi: ");
        for(int i=0;i<str.Length;i++){
            Console.Write(str[i] + " ");
            
        }
        
    }
}