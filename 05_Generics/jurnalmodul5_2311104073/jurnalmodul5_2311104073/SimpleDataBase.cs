using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Gunakan tiga digit dari NIM, misalnya 12, 34, dan 56
        int angka1 = 12;
        int angka2 = 34;
        int angka3 = 56;

        // Buat instance SimpleDataBase dengan tipe data int
        SimpleDataBase<int> database = new SimpleDataBase<int>();

        // Menambahkan data ke dalam database
        database.AddNewData(angka1);
        database.AddNewData(angka2);
        database.AddNewData(angka3);

        // Menampilkan semua data yang telah ditambahkan
        database.PrintAllData();
    }
}

class SimpleDataBase<T>
{
    private List<T> storedData = new List<T>();
    private List<DateTime> inputDates = new List<DateTime>();

    public void AddNewData(T item)
    {
        storedData.Add(item);
        inputDates.Add(DateTime.UtcNow);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
        }
    }
}
