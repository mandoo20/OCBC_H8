using System;

public class ProblemF{
    public static void Main(){
        string str1,str2 = "";

        Console.WriteLine("\n\n\n====Palindrome Checkers 2.0====\n");
        Console.Write("Enter a Text or Number: ");
        str1 = Console.ReadLine();

        for(int i=str1.Length-1;i>=0;i--){
            str2 += str1[i];
        }

        if( str1 == str2){
            Console.WriteLine($"\nInputted is {str1}");
            Console.WriteLine($"Reversed is {str2}");

            Console.WriteLine("\nPalindrome Text Correct!");
        }
        else{
            Console.WriteLine($"\n\nInputted is {str1}");
            Console.WriteLine($"Reversed is {str2}");
            Console.WriteLine("Nah..Try Other Text or Number");
        }
    }
}