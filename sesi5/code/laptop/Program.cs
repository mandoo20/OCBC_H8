using System;

namespace laptop
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop();

            //akses atribut
            // laptop1.merk = "Asus";
            // laptop1.ram = 4;
            // laptop1.memory = 512;

            Console.Write("Enter Merk Laptop: ");
            laptop1.merk = Console.ReadLine();

            Console.Write("Enter Ram[4|8|12]: ");
            laptop1.ram = int.Parse(Console.ReadLine());

            Console.Write("Enter SSD Memory[128|256|512]: ");
            laptop1.memory = int.Parse(Console.ReadLine());    

            //Tampilkan
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("\nMerk Laptop adalah {0}", laptop1.merk);
            Console.WriteLine("\nKapasitas ramnya ada {0} GB DDR4", laptop1.ram);
            Console.WriteLine("\nKapasitas Memory SSD ada {0} GB", laptop1.memory);

            //Akses Method
            laptop1.Chatting();
            laptop1.Sosmed();
            laptop1.OnlineShop();

            Console.Read();
        }
    }
}
