using System;

public class ProblemB{

    public static void Main(string[] args){

            int input,idx,temp;
            Console.Write("Input Number: ");
            input = int.Parse(Console.ReadLine());

            for(int i = 1;i<=input;i++){
                idx = 1;
                for(int j = i;j<=input;j++){
                    Console.Write(" ");
                }

                for(int j = 1;j<=(2*i-1);j++){
                    temp = (2*i-1)/2;
                    if(j > temp){
                        Console.Write(idx);
                        idx--;

                    }
                    else{
                        Console.Write(idx);
                        idx++;

                    }
                    
                }
                Console.WriteLine();
            }

        
    }
}