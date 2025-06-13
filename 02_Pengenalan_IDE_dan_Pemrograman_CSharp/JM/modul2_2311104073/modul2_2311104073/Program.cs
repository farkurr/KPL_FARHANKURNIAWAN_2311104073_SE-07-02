using System;

namespace modul2_2311104073
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bagian A: Input Nama
            Console.Write("Masukkan nama Anda: ");
            string nama = Console.ReadLine();
            Console.WriteLine($"Selamat datang, {nama}!");

            // Bagian B: Array dengan aturan print khusus
            int[] data = new int[50];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = i;
                if (i % 6 == 0 && i != 0)
                    Console.WriteLine($"{i} #$#$");
                else if (i % 2 == 0 && i != 0)
                    Console.WriteLine($"{i} ##");
                else if (i % 3 == 0)
                    Console.WriteLine($"{i} $$");
                else
                    Console.WriteLine($"{i}");
            }

            // Bagian C: Input angka & cek bilangan prima
            Console.Write("Masukkan sebuah angka (1-10000): ");
            string inputAngka = Console.ReadLine();
            int nilaiInt = Convert.ToInt32(inputAngka);

            if (IsPrima(nilaiInt))
                Console.WriteLine($"Angka {nilaiInt} merupakan bilangan prima");
            else
                Console.WriteLine($"Angka {nilaiInt} bukan merupakan bilangan prima");
        }

        static bool IsPrima(int angka)
        {
            if (angka <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(angka); i++)
            {
                if (angka % i == 0) return false;
            }
            return true;
        }
    }
}
