using System;
using System.Collections.Generic;

/// <summary>
/// Kelas singleton untuk menyimpan dan mengelola data string secara global.
/// </summary>
public class PusatDataSingleton
{
    // Static instance tunggal dari PusatDataSingleton
    private static PusatDataSingleton _instance;

    /// <summary>
    /// List untuk menyimpan data berupa string.
    /// </summary>
    public List<string> DataTersimpan { get; }

    // Konstruktor private agar tidak bisa diakses dari luar class
    private PusatDataSingleton()
    {
        DataTersimpan = new List<string>();
    }

    /// <summary>
    /// Mengembalikan instance tunggal dari PusatDataSingleton.
    /// </summary>
    /// <returns>Instance dari PusatDataSingleton</returns>
    public static PusatDataSingleton GetDataSingleton()
    {
        if (_instance == null)
        {
            _instance = new PusatDataSingleton();
        }

        return _instance;
    }

    /// <summary>
    /// Mengembalikan seluruh data dalam list.
    /// </summary>
    /// <returns>List string</returns>
    public List<string> GetSemuaData()
    {
        return DataTersimpan;
    }

    /// <summary>
    /// Menampilkan seluruh data satu per satu.
    /// </summary>
    public void PrintSemuaData()
    {
        foreach (var data in DataTersimpan)
        {
            Console.WriteLine(data);
        }
    }

    /// <summary>
    /// Menambahkan satu data ke dalam list.
    /// </summary>
    /// <param name="input">Data yang akan ditambahkan</param>
    public void AddSebuahData(string input)
    {
        DataTersimpan.Add(input);
    }

    /// <summary>
    /// Menghapus data dari list berdasarkan index.
    /// </summary>
    /// <param name="index">Index data yang akan dihapus</param>
    public void HapusSebuahData(int index)
    {
        if (index >= 0 && index < DataTersimpan.Count)
        {
            DataTersimpan.RemoveAt(index);
        }
    }
}
