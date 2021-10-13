using System;

namespace hello
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string fname, lname, alamat,tanggalLahir;
            int umur;

            Console.Write("enter your first name : ");
            fname = Console.ReadLine();

            Console.Write("enter your last name : ");
            lname = Console.ReadLine();

            Console.Write("enter your Birth of Date (dd/mm/yyyy) : ");
            tanggalLahir = Console.ReadLine();

            
            umur = get_age(Convert.ToDateTime(tanggalLahir));

            Console.Write("enter your Address : ");
            alamat = Console.ReadLine();

            Console.WriteLine("\n================================");
            Console.WriteLine("Your full name is "+fname + " "+lname);
            Console.WriteLine("Your Age is "+umur);
            Console.WriteLine("Your Address is " +alamat);
            Console.WriteLine("Your Birth of Date is "+tanggalLahir);
            Console.WriteLine("================================\n");

        }

        public static int get_age(DateTime dob)
        {
            int age = 0;
            age = DateTime.Now.AddYears(-dob.Year).Year;
            return age;
        }
    }
}