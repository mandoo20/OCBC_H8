using System;

public class ProblemD{
    public static void Main(){

        int input,reverse=0;

        Console.Write("Enter a number: ");
        input = int.Parse(Console.ReadLine());


        while(input!=0){
            reverse = reverse*10 + (input%10);
            input /=10;
        }

        Console.WriteLine($"Reversed Number: {reverse}");

    }
}