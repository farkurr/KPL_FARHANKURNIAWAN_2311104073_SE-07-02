using System;

class Program
{
    static void Main(string[] args)
    {
        // Bagian A - Input huruf dan cek vokal atau konsonan
        Console.Write("Masukkan satu huruf: ");
        char huruf = Convert.ToChar(Console.ReadLine());

        if ("AIUEO".Contains(huruf))
        {
            Console.WriteLine($"Huruf {huruf} merupakan huruf vokal");
        }
        else
        {
            Console.WriteLine($"Huruf {huruf} merupakan huruf konsonan");
        }

        // Bagian B - Array bilangan genap
        int[] bilanganGenap = { 2, 4, 6, 8, 10 };
        for (int i = 0; i < bilanganGenap.Length; i++)
        {
            Console.WriteLine($"Angka genap {i + 1} : {bilanganGenap[i]}");
        }
    }
}
