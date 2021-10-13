using System;

namespace plane
{

    public class Pesawat
    {
        public class class_pesawat
        {
            public string nama;
            private string ket;

            public string ketinggian
            {
                get { return ket; }
                set { ket = value; }
            }

            public void terbang()
            {
                Console.WriteLine("Pesawat dengan nama {0}, sedang take off", this.nama);
            }

            public void sudahTerbang()
            {
                Console.WriteLine("Pesawat sekarang berada pada ketinggian {0}", this.ketinggian);
            }
        }
    }
}