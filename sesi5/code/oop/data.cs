using System;


namespace oop
{


    public class overloarding
    {
        public class data
        {
            public string nama;

            public double n_Telepon;

            public void print(string nama)
            {
                this.nama = nama;
                Console.WriteLine("Namanya adalah : {0}", this.nama);
            }

            public void print(double n_Telepon)
            {
                this.n_Telepon = n_Telepon;
                Console.WriteLine("Nomor HP : {0}", this.n_Telepon);
            }
        }
    }
}