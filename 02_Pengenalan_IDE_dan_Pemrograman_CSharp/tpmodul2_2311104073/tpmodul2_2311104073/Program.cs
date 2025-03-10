using System;

class Program
{
    static void Main()
    {
        // Menerima input satu karakter
        Console.Write("Masukkan satu huruf: ");
        char huruf = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine(); // Pindah baris setelah input

        // Mengecek apakah huruf vokal atau konsonan
        if ("AIUEO".Contains(huruf))
        {
            Console.WriteLine($"Huruf {huruf} merupakan huruf vokal");
        }
        else
        {
            Console.WriteLine($"Huruf {huruf} merupakan huruf konsonan");
        }

        // Membuat array bilangan genap
        int[] bilanganGenap = { 2, 4, 6, 8, 10 };

        // Menampilkan isi array
        for (int i = 0; i < bilanganGenap.Length; i++)
        {
            Console.WriteLine($"Angka genap {i + 1} : {bilanganGenap[i]}");
        }
    }
}
