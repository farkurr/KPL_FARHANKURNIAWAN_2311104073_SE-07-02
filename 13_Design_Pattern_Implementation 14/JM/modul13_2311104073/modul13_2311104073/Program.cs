using System;

class Program
{
    static void Main(string[] args)
    {
        // A. Buat 2 variabel
        var data1 = PusatDataSingleton.GetDataSingleton();
        var data2 = PusatDataSingleton.GetDataSingleton();

        // B. Tambah data di data1
        data1.AddSebuahData("Farhan Kurniawan");
        data1.AddSebuahData("Bagus Prakoso");
        data1.AddSebuahData("Asisten: Rifqi");

        // C. Print isi data2
        Console.WriteLine("Isi data2 sebelum dihapus:");
        data2.PrintSemuaData();

        // D. Hapus nama asisten dari data2
        data2.HapusSebuahData(2);

        // E. Print ulang isi data1
        Console.WriteLine("Isi data1 setelah penghapusan:");
        data1.PrintSemuaData();

        // F. Print jumlah data
        Console.WriteLine("Jumlah data pada data1: " + data1.GetSemuaData().Count);
        Console.WriteLine("Jumlah data pada data2: " + data2.GetSemuaData().Count);
    }
}
