using System;

class HitungNilai4{

    public static void Main(string[] args){
        int age;
        string password;

        Console.Write("Enter your age: ");
        age = int.Parse(Console.ReadLine());

        Console.Write("Password: ");
        password = Console.ReadLine();

        bool isAdult = age > 18, isPasswordValid = password == "OCBC";

        Console.WriteLine(isAdult && isPasswordValid ? "WELCOME TO THE CLUB!" : "Sorry, ty again!");
    }
}