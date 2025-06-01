using System;

class Program
{
    static void Main(string[] args)
    {
        CovidConfig config = new CovidConfig();
        config.LoadConfig();
        config.UbahSatuan();

        Console.Write($"Berapa suhu badan Anda saat ini? Dalam nilai {config.SatuanSuhu}: ");
        double suhu = Convert.ToDouble(Console.ReadLine());

        Console.Write("Berapa hari yang lalu (perkiraan) Anda terakhir memiliki gejala demam? ");
        int hariDemam = Convert.ToInt32(Console.ReadLine());

        bool suhuNormal = false;

        if (config.SatuanSuhu == "celcius")
        {
            suhuNormal = suhu >= 36.5 && suhu <= 37.5;
        }
        else
        {
            suhuNormal = suhu >= 97.7 && suhu <= 99.5;
        }

        if (suhuNormal && hariDemam < config.BatasHariDemam)
        {
            Console.WriteLine(config.PesanDiterima);
        }
        else
        {
            Console.WriteLine(config.PesanDitolak);
        }
    }
}
