using System;

/// <summary>
/// Program utama untuk menguji implementasi Singleton.
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // Membuat dua variabel yang menunjuk ke instance Singleton
        PusatDataSingleton data1 = PusatDataSingleton.GetDataSingleton();
        PusatDataSingleton data2 = PusatDataSingleton.GetDataSingleton();

        // Menambahkan data ke dalam data1
        data1.AddSebuahData("Farhan Kurniawan");
        data1.AddSebuahData("Bagus Prakoso");
        data1.AddSebuahData("Asisten: Rifqi");

        // Menampilkan seluruh data dari data2 (harus sama dengan data1)
        Console.WriteLine("Isi data2 sebelum penghapusan:");
        data2.PrintSemuaData();

        // Menghapus nama asisten dari data2
        data2.HapusSebuahData(2);

        // Menampilkan data dari data1 setelah penghapusan
        Console.WriteLine("\nIsi data1 setelah penghapusan:");
        data1.PrintSemuaData();

        // Menampilkan jumlah data dari kedua objek
        Console.WriteLine($"\nJumlah data pada data1: {data1.GetSemuaData().Count}");
        Console.WriteLine($"Jumlah data pada data2: {data2.GetSemuaData().Count}");
    }
}
