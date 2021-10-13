using System;

namespace oop
{
    class Program
    {

        public int bil1, bil2;

        public void bilangan(int ang1, int ang2)
        {
            bil1 = ang1;
            bil2 = ang2;
        }

        public virtual void penjumlahanPerkalianDll()
        {
            Console.WriteLine("Overiding 1. . . . ------>>>>>>");
            Console.WriteLine("Hasil Penjumlahan angka {0} dan angka {1} = {2}", bil1, bil2, bil1 + bil2);
            Console.WriteLine("Hasil Perkalian angka {0} dab angka {1} = {2}", bil1, bil2, bil1 * bil2);
        }

        class overide : Program
        {
            public override void penjumlahanPerkalianDll()
            {
                //base.penjumlahanPerkalianDll();
                Console.WriteLine("Overiding 2. . . . ------>>>>>>");
                Console.WriteLine("Hasil Pembagian angka {0} dan angka {1} = {2}", bil1, bil2, bil1 / bil2);
                Console.WriteLine("Hasil Pengurangan angka {0} dab angka {1} = {2}", bil1, bil2, bil1 - bil2);

            }
        }


        static void Main(string[] args)
        {
            int choose, bil1, bil2;
            double num;
            string n, name;

            do
            {
                Console.WriteLine("----------Session 5------------------\n");
                Console.WriteLine("1. Pesawat Jet");
                Console.WriteLine("2. Overloading");
                Console.WriteLine("3. Bilangan");
                Console.WriteLine("4. About me");
                Console.WriteLine("5. Exit");
                do
                {
                    Console.Write("Choose: ");
                    choose = int.Parse(Console.ReadLine());
                } while (choose < 1 || choose > 5);

                switch (choose)
                {
                    case 1:
                        {
                            Console.WriteLine("\n\n");
                            pesawat.plane pesawat = new pesawat.plane();
                            pesawat.jet psJet = new pesawat.jet();

                            Console.Write("Enter Plane Name: ");
                            pesawat.nama = Console.ReadLine();
                            pesawat.jRoda = 3;
                            pesawat.ketinggian = "1000 kaki";
                            pesawat.jPenumpang = "3 Penumpang";

                            Console.Write("Enter Jet Plane Name: ");
                            psJet.nama = Console.ReadLine();
                            psJet.jRoda = 5;
                            psJet.ketinggian = "200 kaki";
                            psJet.jPenumpang = "2 Penumpang plus kopilot dan asistance";

                            pesawat.terbang();
                            Console.WriteLine();
                            psJet.terbangJet();

                            Console.Write("\nBack to Home Page[y/n]: ");
                            n = Console.ReadLine();
                            if (n == "n")
                            {
                                choose = 5;
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\n\n");
                            overloarding.data datanew = new overloarding.data();

                            Console.Write("Enter your name: ");
                            name = Console.ReadLine();
                            Console.Write("Enter your Phone Number: ");
                            num = double.Parse(Console.ReadLine());

                            Console.WriteLine("\n\n");

                            datanew.print(name);
                            datanew.print(num);
                            Console.WriteLine("\n\n");

                            Console.Write("\nBack to Home Page[y/n]: ");
                            n = Console.ReadLine();
                            if (n == "n")
                            {
                                choose = 5;
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\n\n");
                            Program overiding = new Program();

                            Console.Write("Enter a First Number: ");
                            bil1 = int.Parse(Console.ReadLine());
                            Console.Write("Enter a Second Number: ");
                            bil2 = int.Parse(Console.ReadLine());

                            Console.WriteLine();
                            overiding.bilangan(bil1, bil2);
                            overiding.penjumlahanPerkalianDll();

                            overiding = new overide();

                            Console.WriteLine();
                            overiding.bilangan(bil1, bil2);
                            overiding.penjumlahanPerkalianDll();


                            Console.Write("\nBack to Home Page[y/n]: ");
                            n = Console.ReadLine();
                            if (n == "n")
                            {
                                choose = 5;
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\n\n");
                            Console.WriteLine("=====================================================");
                            Console.WriteLine("----------------- ASSIGMENT 5 -----------------------");
                            Console.WriteLine("  NAMA         : ARMANDO FRANSISCO ONGKO");
                            Console.WriteLine("  KODE PESERTA : FSDO001ONL026");
                            Console.WriteLine("  ALAMAT       : RIAU, BENGKALIS");
                            Console.WriteLine("=====================================================");
                            Console.WriteLine("untuk Kelas C# dari Pertemuan 1 -5 cukup menyenangkan \ndan lancar, terus sangat membantu saya membiasakan \nkembali mengetik syntak-syntak C yang dulu sangat \nsering saya pakai selama semester 1- 3 dalam nugas \nmaupun latihan logic di Codeforce/Vjudge.");

                            Console.Write("\nBack to Home Page[y/n]: ");
                            n = Console.ReadLine();
                            if (n == "n")
                            {
                                choose = 5;
                            }
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            } while (choose != 5);

            Console.WriteLine("\n\n\n\nThank You!");

        }
    }

}
