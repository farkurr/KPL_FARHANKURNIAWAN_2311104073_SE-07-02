using System;
using System.IO;
using System.Text.Json;

public class CovidConfig
{
    public string SatuanSuhu { get; set; } = "celcius";
    public int BatasHariDemam { get; set; } = 14;
    public string PesanDitolak { get; set; } = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
    public string PesanDiterima { get; set; } = "Anda dipersilahkan untuk masuk ke dalam gedung ini";

    private const string ConfigPath = "covid_config.json";

    public void LoadConfig()
    {
        if (File.Exists(ConfigPath))
        {
            string jsonString = File.ReadAllText(ConfigPath);
            CovidConfig? config = JsonSerializer.Deserialize<CovidConfig>(jsonString);

            if (config != null)
            {
                SatuanSuhu = config.SatuanSuhu;
                BatasHariDemam = config.BatasHariDemam;
                PesanDitolak = config.PesanDitolak;
                PesanDiterima = config.PesanDiterima;
            }
        }
    }

    public void UbahSatuan()
    {
        SatuanSuhu = SatuanSuhu == "celcius" ? "fahrenheit" : "celcius";
    }
}
