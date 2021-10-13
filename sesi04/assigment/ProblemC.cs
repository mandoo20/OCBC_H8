using System;

public class ProblemC{

    public static void Main(){

        int input,hasil;

        Console.Write("Enter any Number: ");
        input = int.Parse(Console.ReadLine());
        hasil =1;
        for(int i=2;i<=input;i++){
            hasil *=i;
        }
        Console.WriteLine($"Factorial of {input} is: {hasil}");

    }
}