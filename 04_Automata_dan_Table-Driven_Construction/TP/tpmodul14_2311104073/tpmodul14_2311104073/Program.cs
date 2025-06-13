class Program
{
    static void Main(string[] args)
    {
        KodePos kp = new KodePos();
        Console.WriteLine("Kode Pos Batununggal: " + kp.getKodePos("Batununggal"));
        Console.WriteLine("Kode Pos Maleer: " + kp.getKodePos("Maleer"));
    }
}
