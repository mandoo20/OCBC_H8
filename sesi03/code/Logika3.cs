using System;

class Logika3
{

    public static void Main(string[] args)
    {
        string uname, pass;
        int flag;

        do
        {
            flag = 1;
            Console.Write("Username: ");
            uname = Console.ReadLine();

            Console.Write("Password: ");
            pass = Console.ReadLine();

            bool isUsernameValid = uname == "ocbc", isPasswordValid = pass == "bootcamp";

            //Console.WriteLine(isUsernameValid && isPasswordValid ? "Anda berhasil login" : "Username atau Password anda salah");
            if (isUsernameValid && isPasswordValid)
            {
                Console.WriteLine("Anda berhasil login");
            }
            else
            {
                Console.WriteLine("Username atau Password anda salah");
                flag = 0;
            }

        } while (flag == 0);


    }
}