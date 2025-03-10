using System;

class Program
{
    static void Main(string[] args)
    {
        // Implementasi Table-Driven
        Console.WriteLine("Kode Buah Apel: " + KodeBuah.GetKodeBuah("Apel"));
        Console.WriteLine("Kode Buah Durian: " + KodeBuah.GetKodeBuah("Durian"));

        // Implementasi State-Based Construction
        PosisiKarakterGame karakter = new PosisiKarakterGame();
        karakter.TekanTombol("W");
        karakter.TekanTombol("S");
        karakter.TekanTombol("Terbang");
        karakter.TekanTombol("Jongkok");
    }
}
