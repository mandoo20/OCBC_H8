using System;

namespace oop
{


    public class pesawat
    {
        public class plane
        {
            public string nama;
            private string ket;
            private string jumlahPenumpang;
            private int jumlahRoda;

            public string ketinggian
            {
                get { return ket; }
                set { ket = value; }
            }

            public string jPenumpang
            {
                get { return jumlahPenumpang; }
                set { jumlahPenumpang = value; }
            }

            public int jRoda
            {
                get { return jumlahRoda; }
                set { jumlahRoda = value; }
            }

            public void terbang()
            {
                Console.WriteLine("Pesawat dengan nama {0}, yang mempunyai jumlah roda {1},sedang berada pada ketinggian {2} dengan membawa jumlah penumpang sebanyak {3}.", this.nama, this.jRoda, this.ketinggian, this.jPenumpang);
            }
        }

        public class jet : plane
        {

            public void terbangJet()
            {
                Console.WriteLine("Pesawat Tempur dengan nama {0}, yang mempunyai jumlah roda {1},sedang berada pada ketinggian {2} dengan membawa jumlah penumpang sebanyak {3} akan menembakkan senjata.", this.nama, this.jRoda, this.ketinggian, this.jPenumpang);
            }
        }
    }
}