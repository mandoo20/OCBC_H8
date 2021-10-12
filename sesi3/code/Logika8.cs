using System;

public class Logika8{

    public static void Main(){
        int i,angka1, opsi,flag = 0;
        Console.Write("Masukkan Angka: ");
        angka1 = int.Parse(Console.ReadLine());

        Console.WriteLine("1. Operator Penambahan +");
        Console.WriteLine("2. Operator Pengurangan -");
        Console.WriteLine("3. Operator Perkalian *");        
        Console.WriteLine("4. Operator Pembagian /");
        Console.Write("Opsi[1-4]: ");
        opsi = int.Parse(Console.ReadLine());
        
        switch (opsi)
        {
            case 1:{
                flag = 0;
                i= 1;
                do{
                    Console.WriteLine($"i ke {flag+1} = {i}");
                    i  +=angka1;
                    // if (i>5){
                    //     break;
                    // }
                    flag++;
                } while (flag < 5);
                break;
            }
            case 2:{
                flag = 0;
                i= 1;
                do{
                    Console.WriteLine("i = {0}",i);
                    i  -=angka1;
                    // if (i>5){
                    //     break;
                    // }
                    flag++;

                } while (flag < 5);
                break;
            }
            case 3:{
                flag = 0;
                i= 1;
                do{
                    Console.WriteLine("i = {0}",i);
                    i  *=angka1;
                    // if (i>5){
                    //     break;
                    // }
                    flag++;

                } while (flag < 5);
                break;
            }
            case 4:{
                flag = 0;
                i= 1;
                do{
                    Console.WriteLine("i = {0}",i);
                    i  /=angka1;
                    // if (i>5){
                    //     break;
                    // }
                    flag++;

                } while (flag < 5);
                break;
            }
            default:{
                Console.WriteLine("Opsi Error!");
                break;
            }
        }


    }
}