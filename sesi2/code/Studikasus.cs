using System;

class StudiKasus
{
    public static void Main(string[] args)
    {
        //026_Armando Fransisco Ongko
        //------------------------------------
        int a,b,c,total;
        double avg;

        string username,password,gender,nama, status;
        bool statusNikah;
        int age,flag = 1;

        while (flag == 1)
        {
            flag = 0;
            Console.Write("nama: ");
            nama = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Gender[L/P]: ");
            gender = Console.ReadLine();

            gender = gender == "L" ? "Laki-Laki" : "Perempuan";

            Console.Write("Status Nikah[t/f]: ");
            status = Console.ReadLine();

            statusNikah = status == "t" ? true : false;

            Console.Write("Username: ");
            username = Console.ReadLine();

            Console.Write("Password: ");
            password = Console.ReadLine();


            bool isAdult = age > 18, isPasswordValid = password == "OCBC", isUsername = username == "Armando026";
            if (isAdult && isPasswordValid && isUsername)
            {
                Console.WriteLine("\n===Menghitung Nilai===");
                Console.Write("Masukan nilai PERTAMA: ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Masukan nilai KEDUA: ");
                b = int.Parse(Console.ReadLine());

                Console.Write("Masukan nilai KETIGA: ");
                c = int.Parse(Console.ReadLine());
                
                total = a+b+c;
                avg = total/3.0;

                Console.WriteLine("\n===Biodata===");
                Console.WriteLine("Umur: "+age);
                Console.WriteLine("Nama: "+nama);
                Console.WriteLine("Gender: "+gender);
                Console.WriteLine("Status Nikah: "+statusNikah);

                Console.WriteLine("\n===Aritmatika===");
                Console.WriteLine("Total Nilai adalah: "+total);
                Console.WriteLine("Rata Rata Nilai adalah: "+avg);
            }
            else
            {
                flag = 1;
                Console.WriteLine("Sorry, Try Again!\n\n\n\n");
            }
        }

        //------------------------------------
        
    }
}