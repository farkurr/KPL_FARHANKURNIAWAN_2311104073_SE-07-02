using System;
using AljabarLibraries;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Contoh pemanggilan HasilKuadrat
            double[] kuadrat = Aljabar.HasilKuadrat(new double[] { 2, -3 });
            Console.WriteLine("Hasil Kuadrat:");
            foreach (var item in kuadrat)
                Console.Write(item + " ");
            Console.WriteLine();

            // Contoh pemanggilan AkarPersamaanKuadrat
            double[] akar = Aljabar.AkarPersamaanKuadrat(new double[] { 1, -3, -10 });
            Console.WriteLine("Akar Persamaan Kuadrat:");
            foreach (var item in akar)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}
