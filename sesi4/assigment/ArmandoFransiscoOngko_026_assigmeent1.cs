using System;

public class ArmandoFransiscoOngko_026_assigment1
{

    public static void Main(string[] args)
    {
        string[] huruf = new string[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        string[] number = new string[10] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string inputS, str1, str2;
        int choose, input, idx, temp, hasil, reverse = 0;

        do
        {

            printEnter();
            Console.WriteLine("===============================================");
            Console.WriteLine("----------------- ASSIGMENT 1 -----------------");
            Console.WriteLine("  NAMA         : ARMANDO FRANSISCO ONGKO");
            Console.WriteLine("  KODE PESERTA : FSDO001ONL026");
            Console.WriteLine("  ALAMAT       : RIAU, BENGKALIS");
            Console.WriteLine("===============================================");
            Console.WriteLine("1. Problem A");
            Console.WriteLine("2. Problem B");
            Console.WriteLine("3. Problem C");
            Console.WriteLine("4. Problem D");
            Console.WriteLine("5. Problem E");
            Console.WriteLine("6. Problem F");
            Console.WriteLine("7. Exit");
            do
            {
                Console.Write("Choose [1-7]: ");
                choose = int.Parse(Console.ReadLine());
            } while (choose < 1 || choose > 7);

            switch (choose)
            {
                case 1:
                    {
                        printEnter();
                        Console.WriteLine("=== Alphabet Pyramid ===\n\n");
                        do
                        {
                            Console.Write("Input Number[1-26]: ");
                            input = int.Parse(Console.ReadLine());
                        } while (input < 0 || input > 26);

                        for (int i = 1; i <= input; i++)
                        {
                            idx = 0;
                            for (int j = i; j <= input; j++)
                                Console.Write(" ");
                            for (int j = 1; j <= (2 * i - 1); j++)
                            {
                                temp = (2 * i - 1) / 2;
                                if (j > temp)
                                {
                                    Console.Write(huruf[idx]);
                                    idx--;
                                }
                                else
                                {
                                    Console.Write(huruf[idx]);
                                    idx++;
                                }
                            }
                            Console.WriteLine();
                        }
                        Console.Write("\nPress Any to Continue...");
                        Console.ReadLine();
                        break;
                    }
                case 2:
                    {
                        printEnter();
                        Console.WriteLine("=== Number Pyramid ===\n\n");
                        Console.Write("Input Number: ");
                        input = int.Parse(Console.ReadLine());

                        for (int i = 1; i <= input; i++)
                        {
                            idx = 1;
                            for (int j = i; j <= input; j++)
                            {
                                Console.Write(" ");
                            }

                            for (int j = 1; j <= (2 * i - 1); j++)
                            {
                                temp = (2 * i - 1) / 2;
                                if (j > temp)
                                {
                                    Console.Write(idx);
                                    idx--;
                                }
                                else
                                {
                                    Console.Write(idx);
                                    idx++;
                                }
                            }
                            Console.WriteLine();
                        }
                        Console.Write("\nPress Any to Continue...");
                        Console.ReadLine();
                        break;
                    }
                case 3:
                    {
                        printEnter();
                        Console.WriteLine("=== Factorial ===\n\n");
                        Console.Write("Enter any Number: ");
                        input = int.Parse(Console.ReadLine());
                        hasil = 1;
                        for (int i = 2; i <= input; i++)
                        {
                            hasil *= i;
                        }
                        Console.WriteLine($"Factorial of {input} is {hasil}");
                        Console.Write("\nPress Any to Continue...");
                        Console.ReadLine();
                        break;
                    }
                case 4:
                    {
                        printEnter();
                        Console.WriteLine("=== Reversed Number ===\n\n");
                        Console.Write("Enter a number: ");
                        input = int.Parse(Console.ReadLine());

                        while (input != 0)
                        {
                            reverse = reverse * 10 + (input % 10);
                            input /= 10;
                        }

                        Console.WriteLine($"Reversed Number is {reverse}");
                        Console.Write("\nPress Any to Continue...");
                        Console.ReadLine();
                        break;
                    }
                case 5:
                    {
                        printEnter();
                        Console.WriteLine("=== Number Converter ===\n\n");
                        Console.Write("Enter a number: ");
                        inputS = Console.ReadLine();
                        idx = 0;
                        do
                        {
                            if (inputS[idx] == '0')
                            {
                                Console.Write(number[0] + " ");
                            }
                            else if (inputS[idx] == '1')
                            {
                                Console.Write(number[1] + " ");
                            }
                            else if (inputS[idx] == '2')
                            {
                                Console.Write(number[2] + " ");
                            }
                            else if (inputS[idx] == '3')
                            {
                                Console.Write(number[3] + " ");
                            }
                            else if (inputS[idx] == '4')
                            {
                                Console.Write(number[4] + " ");
                            }
                            else if (inputS[idx] == '5')
                            {
                                Console.Write(number[5] + " ");
                            }
                            else if (inputS[idx] == '6')
                            {
                                Console.Write(number[6] + " ");
                            }
                            else if (inputS[idx] == '7')
                            {
                                Console.Write(number[7] + " ");
                            }
                            else if (inputS[idx] == '8')
                            {
                                Console.Write(number[8] + " ");
                            }
                            else if (inputS[idx] == '9')
                            {
                                Console.Write(number[9] + " ");
                            }
                            idx++;
                        } while (idx < inputS.Length);
                        Console.Write("\nPress Any to Continue...");
                        Console.ReadLine();
                        break;
                    }
                case 6:
                    {
                        printEnter();
                        Console.WriteLine("=== Palindrome Checker ===\n\n");
                        Console.Write("Enter a Text or Number: ");
                        str1 = Console.ReadLine();
                        str2= "";
                        for (int i = str1.Length - 1; i >= 0; i--)
                        {
                            str2 += str1[i];
                        }
                        if (str1 == str2)
                        {
                            Console.WriteLine($"\nInputted is {str1}");
                            Console.WriteLine($"Reversed is {str2}");
                            Console.WriteLine("\nPalindrome Text Correct!");
                        }
                        else
                        {
                            Console.WriteLine($"\n\nInputted is {str1}");
                            Console.WriteLine($"Reversed is {str2}");
                            Console.WriteLine("Nah..Try Other Text or Number");
                        }
                        Console.Write("\nPress Any to Continue...");
                        Console.ReadLine();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }




        } while (choose != 7);
        printEnter();
        Console.WriteLine("THANK YOU!");
        Console.ReadLine();
    }

    public static void printEnter()
    {
        for (int i = 0; i < 30; i++)
        {
            Console.WriteLine();
        }
    }

}