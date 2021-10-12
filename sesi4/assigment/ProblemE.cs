using System;

public class ProblemE{
    public static void Main(){

        string input;
        int idx;
        string[] number = new string[10]{"zero","one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        
        Console.Write("Enter a number: ");
        input = Console.ReadLine();
        idx = 0;
        do
        {
            if(input[idx] == '0'){
                Console.Write(number[0]+" ");
            }
            else if(input[idx] == '1'){
                Console.Write(number[1]+" ");
            }
            else if(input[idx] == '2'){
                Console.Write(number[2]+" ");
            }
            else if(input[idx] == '3'){
                Console.Write(number[3]+" ");
            }
            else if(input[idx] == '4'){
                Console.Write(number[4]+" ");
            }
            else if(input[idx] == '5'){
                Console.Write(number[5]+" ");
            }
            else if(input[idx] == '6'){
                Console.Write(number[6]+" ");
            }
            else if(input[idx] == '7'){
                Console.Write(number[7]+" ");
            }
            else if(input[idx] == '8'){
                Console.Write(number[8]+" ");
            }
            else if(input[idx] == '9'){
                Console.Write(number[9]+" ");
            }
            idx++;
        } while (idx < input.Length);


    }
}