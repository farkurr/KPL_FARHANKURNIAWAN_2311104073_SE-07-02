using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Program berhasil dijalankan!");

        // Demonstrasi Table-Driven
        Console.WriteLine("Kode Pos Batununggal: " + KodePos.GetKodePos("Batununggal"));
        Console.WriteLine("Kode Pos Maleer: " + KodePos.GetKodePos("Maleer"));

        // Demonstrasi State-Based Construction
        DoorMachine pintu = new DoorMachine();
        pintu.Unlock();
        pintu.Lock();
    }
}
