using System;

public class Laptop
{

    class Laptop
    {
        //Atrribute/Variable
        public string merk;
        public int  ram;
        public int memory;

        //method
        public void Chatting(){
            Console.WriteLine("\n{0} sedang chatting", this.merk);
        }

        public void Sosmed(){
            Console.WriteLine("\n{0} sedang melihat sosmeed", this.merk);
        }

        public void OnlineShop(){
            Console.WriteLine("\n{0} sedang mengunakan Online Shop", this.merk);
        }
    }
}