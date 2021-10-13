using System;

public class ProblemA{

    public static void Main(string[] args){
        string[] huruf = new string[26] {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};

            int input,idx,temp;

            Console.WriteLine("===Alphabet Pyramid===");
            Console.Write("Input Number[1-26]: ");
            input = int.Parse(Console.ReadLine());

            for(int i = 1;i<=input;i++){
                idx = 0;
                for(int j = i;j<=input;j++){
                    Console.Write(" ");
                }

                for(int j = 1;j<=(2*i-1);j++){
                    temp = (2*i-1)/2;
                    if(j > temp){
                        Console.Write(huruf[idx]);
                        idx--;

                    }
                    else{
                        Console.Write(huruf[idx]);
                        idx++;

                    }
                    
                }
                Console.WriteLine();
            }

        
    }
}