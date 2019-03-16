//=======================================================================\\
//---------------Created of Programs by Galihrizal-----------------------\\
//---------------------Mohon digunakan dengan bijak----------------------\\
//=======================================================================\\

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, bil1, bil2;
            char pilih, yn;

        awal: //Untuk tanda loncat ke awal koding
            Console.Clear();
            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("==========================================");
            Console.WriteLine("     | Program Kalkulator Sederhana |     ");
            Console.WriteLine("==========================================");
            Console.WriteLine(); //Baris Kosong
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("            | Daftar Pilihan |            ");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(" A. Tambah   C. Kali");
            Console.WriteLine(" B. Kurang   D. Bagi");
            Console.WriteLine("==========================================");
            Console.Write(" Masukkan Pilihan [A..B]: ");
            pilih = char.Parse(Console.ReadLine()); //Proses Casting
            Console.WriteLine(); //Baris Kosong

            if (pilih == 'A' || pilih == 'a')
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("          | Masukkan Nilai |           ");
                Console.WriteLine("=======================================");
                Console.WriteLine();
                Console.WriteLine("---------------------------------------");
                Console.Write("Inputkan Nilai Pertama = ");
                a = int.Parse(Console.ReadLine()); //Proses Casting
                Console.Write("Inputkan Nilai Kedua = ");
                b = int.Parse(Console.ReadLine()); //Proses Casting
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(); //Baris Kosong
                Console.WriteLine("Hasilnya Adalah : " + penambahan(a, b) + "");
            }

            else if (pilih == 'B' || pilih == 'b')
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("          | Masukkan Nilai |           ");
                Console.WriteLine("=======================================");
                Console.WriteLine();
                Console.WriteLine("---------------------------------------");
                Console.Write("Inputkan Nilai Pertama = ");
                a = int.Parse(Console.ReadLine()); //Proses Casting
                Console.Write("Inputkan Nilai Kedua = ");
                b = int.Parse(Console.ReadLine()); //Proses Casting
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(); //Baris Kosong
                Console.WriteLine("Hasilnya Adalah : " + pengurangan(a, b) + "");
            }

            else if (pilih == 'C' || pilih == 'c')
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("          | Masukkan Nilai |           ");
                Console.WriteLine("=======================================");
                Console.WriteLine(); //Baris Kosong
                Console.WriteLine("---------------------------------------");
                Console.Write("Inputkan Nilai Pertama = ");
                a = int.Parse(Console.ReadLine()); //Proses Casting
                Console.Write("Inputkan Nilai Kedua = ");
                b = int.Parse(Console.ReadLine()); //Proses Casting
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(); //Baris Kosong
                Console.WriteLine("Hasilnya Adalah : " + perkalian(a, b) + "");
            }

            else if (pilih == 'D' || pilih == 'd')
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("          | Masukkan Nilai |           ");
                Console.WriteLine("=======================================");
                Console.WriteLine(); //Baris Kosong
                Console.WriteLine("---------------------------------------");
                Console.Write("Inputkan Nilai Pertama = ");
                a = int.Parse(Console.ReadLine()); //Proses Casting
                Console.Write("Inputkan Nilai Kedua = ");
                b = int.Parse(Console.ReadLine()); //Proses Casting
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(); //Baris Kosong
                Console.WriteLine("Hasilnya Adalah : " + pembagian(a, b) + "");
            }
            else
            {
                Console.WriteLine("Maaf pilihan yang anda inputkan tidak terdaftar");
            }

            
            Console.Write("Mau Coba Lagi(y/n)? ");
            yn = char.Parse(Console.ReadLine());
            if (yn == 'Y' || yn == 'y')
            {
                goto awal;
            }
            if(yn == 'N' || yn == 'n')
            {
                goto akhir;
            }
        akhir: //Untuk tanda loncat ke akhir koding
            Console.WriteLine("\n Tekan sembarang key untuk keluar");
            
            Console.ReadKey(); //Supaya ketika project di run tidak keluar otomatis
        }

        //Method Perhitungan
        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
}